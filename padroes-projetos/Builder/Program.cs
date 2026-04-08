using Builder;

//Posso criar o objeto de muitas formas diferentes, com as parametrizações que eu quiser
var cliente = new ClienteBuilder()
                  .ComNome("Antonio")
                  .ComCpf("12345")
                  .ComAltura(1.7)
                  .ComIdade(26)
                  .ComPeso(80.0);