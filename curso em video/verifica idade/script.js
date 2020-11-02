function verificar(){
    var data = new Date();
    var ano = data.getFullYear();
    var fAno =document.getElementById('txtano');
    var res = document.getElementById("res");
   
    if(fAno.value.length == 0 || fAno.value > ano){
        window.alert('[ERRO] verificar os dados e tente novamente!');
    }else{
        var fsex = document.getElementsByName('radsex');
        var idade = ano - Number(fAno.value);
        var img = document.createElement('img');
        img.setAttribute('id', 'foto')
        var genero = '';
        if(fsex[0].checked){
            genero = "Homem";
            if(idade >= 0 && idade <= 10){
              img.setAttribute('src', 'crianca.jpg');
            }else if(idade < 21){
               img.setAttribute('src', 'adolecente.jpg');
            }else if(idade < 50){
               img.setAttribute('src','adulto.jpg');
            }else{
               img.setAttribute('src','velhoM.jpg');
            }
        }else if(fsex[1].checked){
            genero = "Mulher";
            if(idade >= 0 && idade <= 10){
                img.setAttribute('src', 'menina.jpg');
            }else if(idade < 21){
                img.setAttribute('src','jovem.jpg');
            }else if(idade < 50){
                img.setAttribute('src','adultoMulher.jpg');
            }else{
                img.setAttribute('src','velho.jpg');
            }
        }
        res.style.textAlign = 'center'
        res.innerHTML = `Detectamos ${genero} com ${idade} anos.`;
        res.appendChild(img);
    }

}


