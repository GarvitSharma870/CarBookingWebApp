import { Car } from "./car"
import { Company } from "./company"

export interface CarBooking {
    id:number,
    totalPrice: number,
    bookingFrom: Date,
    bookingTo: Date,
    carId: number,
    car: Car,
    companyId: number,
    company: Company,
    userId: string
}