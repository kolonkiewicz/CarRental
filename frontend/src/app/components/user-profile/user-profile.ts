import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { faCheck } from '@fortawesome/free-solid-svg-icons';
import { AuthService } from '../../services/auth-service';

@Component({
  selector: 'app-user-profile',
  imports: [ FormsModule, FontAwesomeModule],
  templateUrl: './user-profile.html',
  styleUrl: './user-profile.css',
})
export class UserProfile {
  faCheck = faCheck;

  activeTab = 'profile';

  private authService = inject(AuthService);

  user = this.authService.getCurrentUser();

  profile = {
    firstName: this.user?.firstName ?? '',
    lastName: this.user?.surname ?? '',
    phone: this.user?.phone ?? '',
    email: this.user?.email ?? ''
  }

  saved = false;

  saveProfile(): void {

    this.saved = true;

    setTimeout(() => {
      this.saved = false;
    }, 3000);
  }
}
