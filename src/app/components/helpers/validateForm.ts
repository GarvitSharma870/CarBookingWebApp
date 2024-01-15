import { FormGroup, FormControl, AbstractControl, ValidationErrors, ValidatorFn } from "@angular/forms";

export default class ValidateForm{
    static validateAllFormFields(formGroup: FormGroup){
        Object.keys(formGroup.controls).forEach(field=>{
          const control = formGroup.get(field);
          if(control instanceof FormControl){
            control.markAsDirty({onlySelf: true});
          }
          else if(control instanceof FormGroup){
            this.validateAllFormFields(control);
          }
        })
      }
}
export function forbiddenTitleValidator(nameRe: RegExp): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    const forbidden = nameRe.test(control.value);
    return forbidden ? null : { forbiddenTitle: { value: control.value } };
  };
}
export function ConfirmedValidator(controlName: string, matchingControlName: string){

    return (formGroup: FormGroup) => {

        const control = formGroup.controls[controlName];

        const matchingControl = formGroup.controls[matchingControlName];

        if (matchingControl.errors) {

            return;

        }

        if (control.value !== matchingControl.value) {

            matchingControl.setErrors({ confirmedValidator: true });

        } else {

            matchingControl.setErrors(null);

        }

    }

}
export function dynamicMaxValidator(maxValue: number): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    if (control.value && +control.value > maxValue) {
      return { max: { maxValue } };
    }
    return null;
  };
}