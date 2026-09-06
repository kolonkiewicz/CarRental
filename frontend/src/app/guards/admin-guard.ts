import { inject } from "@angular/core";
import { CanActivateFn, Router } from "@angular/router";
import { AuthService } from "../services/auth-service";

export const adminGuard: CanActivateFn = () => {
    const authService = inject(AuthService);
    const router = inject(Router);

    const user = authService.getCurrentUser();

    if ( user?.role === 'Admin'){
        return true;
    }

    if ( authService.isLoggedIn()) {
        return router.createUrlTree(['/dashboard']);
    }

    return router.createUrlTree(['auth']);
}