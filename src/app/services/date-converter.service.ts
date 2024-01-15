import { Injectable } from '@angular/core';
import * as moment from 'moment-timezone';
@Injectable({
  providedIn: 'root',
})
export class DateConverterService {
  constructor() {}

  convertLocalDateForBackend(val: Date): Date {
    var d = new Date(val); // val is in UTC
    var localOffset = d.getTimezoneOffset() * 60000;
    var localTime = d.getTime() - localOffset;

    d.setTime(localTime);
    console.log(localTime, d, localOffset, d.getTimezoneOffset());
    return d;
  }

  convertUtcToLocalDate(date: any, offset: any) {
    let convertedDateTime = moment(date)
      .add(-offset, 'minutes')
      .format('YYYY-MM-DD HH:mm');
    return convertedDateTime;
  }

  getOffSetInMinutes(offset: any) {
    const offSetInMinutes = moment.duration(offset).asMinutes();
    return offSetInMinutes;
  }
  calculateTimeDifference(startTime: string, endTime: string): number {
    const format = 'YYYY-MM-DD HH:mm:ss'; // adjust the format based on your time format
  
    const startMoment = moment(startTime, format);
    const endMoment = moment(endTime, format);
    const duration = moment.duration(endMoment.diff(startMoment));
    const hours = duration.asHours();
  
    return hours;
  }
}
