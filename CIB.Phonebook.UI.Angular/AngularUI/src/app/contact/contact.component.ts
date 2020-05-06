import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { ContactService } from '../contact.service';
import { Contact } from '../contact';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  dataSaved = false;
  contactForm: any;
  allContacts: Observable<Contact[]>;
  contactIdUpdate = null;
  message = null;

  constructor(private formbuilder: FormBuilder, private contactService: ContactService) { }

  ngOnInit() {
    this.contactForm = this.formbuilder.group({
      FirstName: ['', [Validators.required]],
      LastName: ['', [Validators.required]],
      Mobile: ['', [Validators.required]],
      WorkTelephone: ['', [Validators.required]]//,
      //DateCreated: ['', [Validators.required]],
      //DateModified: ['', [Validators.required]],
    });
    this.loadAllContacts();
  }
  loadAllContacts() {
    this.allContacts = this.contactService.getAll();
  }
  onFormSubmit() {
    this.dataSaved = false;
    const contact = this.contactForm.value;
    this.createContact(contact);
    this.contactForm.reset();
  }
  loadContactToEdit(id: number) {
    this.contactService.getById(id).subscribe(contact => {
      this.message = null;
      this.dataSaved = false;
      this.contactIdUpdate = contact.Id;
      this.contactForm.controls['FirstName'].setValue(contact.FirstName);
      this.contactForm.controls['LastName'].setValue(contact.LastName);
      this.contactForm.controls['Mobile'].setValue(contact.Mobile);
      this.contactForm.controls['WorkTelephone'].setValue(contact.WorkTelephone);
      //this.contactForm.controls['DateCreated'].setValue(contact.DateCreated);
      //this.contactForm.controls['DateModified'].setValue(contact.DateModified);
    });

  }
  createContact(contact: Contact) {
    if (this.contactIdUpdate == null) {
      contact.DateCreated = new Date();
      contact.DateModified = new Date();
      this.contactService.create(contact).subscribe(
        () => {
          this.dataSaved = true;
          this.message = 'Contact saved successfully';
          this.loadAllContacts();
          this.contactIdUpdate = null;
          this.contactForm.reset();
        }
      );
    } else {
      contact.Id = this.contactIdUpdate;
      contact.DateCreated = contact.DateCreated;
      contact.DateModified = new Date();
      this.contactService.update(contact).subscribe(() => {
        this.dataSaved = true;
        this.message = 'Contact updated successfully';
        this.loadAllContacts();
        this.contactIdUpdate = null;
        this.contactForm.reset();
      });
    }
  }

  deleteContact(id: number) {
    if (confirm("Are you sure you want to delete this?")) {
      this.contactService.deleteById(id).subscribe(() => {
        this.dataSaved = true;
        this.message = 'Contact deleted successfully';
        this.loadAllContacts();
        this.contactIdUpdate = null;
        this.contactForm.reset();

      });
    }
  }
  resetForm() {
    this.contactForm.reset();
    this.message = null;
    this.dataSaved = false;
  }

}

