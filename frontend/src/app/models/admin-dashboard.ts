export interface AdminDashboardDto {
  usersCount: number;
  activeReservations: number;
  totalReservations: number;
  revenue: number;
  availableCars: number;
  totalCars: number;
  recentReservations: AdminReservation[];
}

export interface AdminReservation{
  reservationId: number,
  customerName: string,
  carName: string,
  startDate: string,
  endDate: string,
  totalPrice: number;
  status: string;
}