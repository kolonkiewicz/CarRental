export interface AdminDashboardDto {
  usersCount: number;
  activeReservations: number;
  totalReservations: number;
  revenue: number;
  availableCars: number;
  totalCars: number;
  recentReservations: AdminReservationDto[];
}

export interface AdminReservationDto{
  reservationId: number,
  customerName: string,
  carName: string,
  startDate: string,
  endDate: string,
  pickupLocation: string,
  returnLocation: string,
  totalPrice: number;
  status: string;
}