import { Routes } from '@angular/router';
import { Home } from './pages/home/home'
import { Auth } from './pages/auth/auth';
import { MainLayout } from './layouts/main-layout/main-layout';
import { AuthLayout } from './layouts/auth-layout/auth-layout';
import { Component } from '@angular/core';

export const routes: Routes = [
    {
        path: '',
        component: MainLayout,
        children:[
            {
                path: '',
                component: Home
            }
        ]
    },
    {
        path: 'auth',
        component: AuthLayout,
        children:[
            {
                path: '',
                component: Auth
            }
        ]
    },
    
];
