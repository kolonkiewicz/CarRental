import { Routes } from '@angular/router';
import { Home } from './pages/home/home'
import { Auth } from './pages/auth/auth';
import { MainLayout } from './layouts/main-layout/main-layout';
import { AuthLayout } from './layouts/auth-layout/auth-layout';
import { Component } from '@angular/core';
import { Cars } from './pages/cars/cars';
import { CarDetail } from './pages/car-detail/car-detail';

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
    {
        path: 'fleet',
        component: Cars
    },
    {
        path:"car-details",
        component: CarDetail
    }
    
];
