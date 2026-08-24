export interface Car{
  id: number;
  brand: string;
  model: string;
  category: string;
  imageUrl: string;
  description: string;
  year: number;
  seats: number;
  fuelType: string;
  transmission: string;
  power: number;
  range: string;
  pricePerDay: number;
  rating: number;
  reviewsCount: number;
  isFeatured: boolean;
  isAvailable: boolean;
  badge?: string;
}