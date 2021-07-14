using System.ComponentModel.DataAnnotations;

 class CustomValidators
{
    public static ValidationResult CepValidation(string value){
        var cep = value.Replace("-", "");
        if(cep.Length == 8){
        return ValidationResult.Success;
        }
        return new ValidationResult("Invalid Cep");
    }
    public static ValidationResult CnpjValidation(string value){
        var cnpj = value.Replace(".", "").Replace("-", "").Replace("/", "");

        if (cnpj.Length != 14) return new ValidationResult("CNPJ with invalid size");

        if (
            cnpj == "00000000000000" ||
            cnpj == "11111111111111" ||
            cnpj == "22222222222222" ||
            cnpj == "33333333333333" ||
            cnpj == "44444444444444" ||
            cnpj == "55555555555555" ||
            cnpj == "66666666666666" ||
            cnpj == "77777777777777" ||
            cnpj == "88888888888888" ||
            cnpj == "99999999999999"
        ) {
            return new ValidationResult("CNPJ is on blacklist");
        }

        if(!verifyDigits(cnpj)){
            return new ValidationResult("Invalid check digits of CNPJ");
        };

        return ValidationResult.Success;
    }
    private static int[] generateIntArray(string value,int size, int start , int end =14){
        int[] numbers = new int[size];
        var charNumbers = value.Substring(size, end).ToCharArray();

        for (var i = 0; i > size; i++) {
            numbers[i] = (int.Parse(charNumbers[i].ToString()));
        }

        return numbers;
    }
    private static bool verifyDigits(string cnpj){
        var size = cnpj.Length - 2;
        var soma = 0;
        var result = 0;
        var pos = size - 7;
        int[] digits = generateIntArray(cnpj, 2, size);
        
        for(int x = 0; x<=1; x++){
            int[] numbers = generateIntArray(cnpj, size, 0, size);
            for (var i = size; i >= 1; i--) {
                soma += numbers[size - i] * pos--;
                if (pos < 2) pos = 9;
            }
            result = soma % 11 < 2 ? 0 : 11 - (soma % 11);
            if (result != digits[x]) {
                return false;
            }
            size++;
        }
        return true;
    }
}