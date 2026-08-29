export interface ReservationDto {
  reservationId: number;

  car: {
    carId: number;
    brand: string;
    model: string;
    imageUrl: string;
    pricePerDay: number;
  };

  startDate: string;
  endDate: string;

  pickupLocation: string;
  returnLocation: string;

  totalPrice: number;
  status: string;
}