export interface CreateReservationDto {
  carId: number;
  startDate: string;
  endDate: string;
  pickupLocation: string;
  returnLocation: string;
}