import { TestBed } from '@angular/core/testing';

import { DateConverterService } from './date-converter.service';

describe('DataConverterService', () => {
  let service: DateConverterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DateConverterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
