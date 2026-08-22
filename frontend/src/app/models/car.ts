export interface Car{
  id: number;
  brand: string;
  model: string;
  category: string;
  imageUrl: string;
  year: number;
  seats: number;
  fuelType: string;
  transmission: string;
  power: number;
  range: string;
  pricePerDay: number;
  rating: number;
  reviewsCount: number;
  isAvailable: boolean;
  badge?: string;
}