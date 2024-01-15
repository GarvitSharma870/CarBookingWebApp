import { Company } from "./company"

export interface Car {
    id: number,
    carName: string,
    number: number,
    price: number,
    slots: number,
    availabilityFrom: Date,
    availabilityTo: Date,
    isActive: boolean,
    companyId: number,
    company: Company,
    userId: string
}