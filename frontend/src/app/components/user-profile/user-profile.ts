import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { faCheck } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-user-profile',
  imports: [ FormsModule, FontAwesomeModule],
  templateUrl: './user-profile.html',
  styleUrl: './user-profile.css',
})
export class UserProfile {
  faCheck = faCheck;

  activeTab = 'profile';

  profile = {
    firstName: 'Jan',
    lastName: 'Kowalski',
    phone: '',
    city: '',
    email: 'jan@gmail.com'
  };

  newPass = '';
  confirmPass = '';

  saved = false;


  saveProfile(): void {

    if (this.newPass && this.newPass !== this.confirmPass) {
      return;
    }

    this.saved = true;

    setTimeout(() => {
      this.saved = false;
    }, 3000);
  }
}
