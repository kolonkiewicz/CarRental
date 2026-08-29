import { Routes } from '@angular/router';
import { Home } from './pages/home/home'
import { Auth } from './pages/auth/auth';
import { MainLayout } from './layouts/main-layout/main-layout';
import { AuthLayout } from './layouts/auth-layout/auth-layout';
import { Component } from '@angular/core';
import { Cars } from './pages/cars/cars';
import { CarDetail } from './pages/car-detail/car-detail';
import { UserDashboard } from './pages/user-dashboard/user-dashboard';
import { AdminDashboard } from './pages/admin-dashboard/admin-dashboard';
import { AdminMainPage } from './components/admin-main-page/admin-main-page';
import { AdminUser } from './components/admin-user/admin-user';
import { AdminReservation } from './components/admin-reservation/admin-reservation';
import { AdminFleet } from './components/admin-fleet/admin-fleet';

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
        path:"cars/:id",
        component: CarDetail
    },
    {
        path:'dashboard',
        component: UserDashboard
    },
    {
        path:'admin',
        component: AdminDashboard,
        children: [
            {
                path: '',
                redirectTo: 'dashboard',
                pathMatch: 'full'
            },
            {
                path: 'dashboard',
                component: AdminMainPage
            },
            {
                path: 'users',
                component: AdminUser
            },
            {
                path: 'reservations',
                component: AdminReservation
            },
            {
                path: 'fleet',
                component: AdminFleet
            }
        ]
    }
    
];
