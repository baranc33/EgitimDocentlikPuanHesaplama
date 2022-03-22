

function birbirEkle() {let ul=document.querySelector('#birbirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="birbirdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Makale Sayısı</label>
<input type="number" name="birbirmakale[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="birbiryazar[]" value="0" class="form-control w-100">
</div>
</li>`;
liDom.classList.add('row'); ul.append(liDom);
}
function birikiEkle() {let ul=document.querySelector('#birikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="birikidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Makale Sayısı</label>
<input type="number" name="birikimakale[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="birikiyazar[]" value="0" class="form-control w-100">
</div>

</li>`;
liDom.classList.add('row'); ul.append(liDom);
}

function birucEkle() {let ul=document.querySelector('#birucul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="birucdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Makale Sayısı</label>
<input type="number" name="birucmakale[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="birucyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}






function ikibirEkle() {let ul=document.querySelector('#ikibirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ikibirdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Makale Sayısı</label>
<input type="number" name="ikibirmakale[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ikibiryazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
function ikiikiEkle() {let ul=document.querySelector('#ikiikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ikiikidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Makale Sayısı</label>
<input type="number" name="ikiikimakale[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ikiikiyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}







function ucbirEkle() {let ul=document.querySelector('#ucbirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ucbirdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Yayın Sayısı</label>
<input type="number" name="ucbiryayin[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ucbiryazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
function ucikiEkle() {let ul=document.querySelector('#ucikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ucikidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Yayın Sayısı</label>
<input type="number" name="ucikiyayin[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ucikiyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
function ucucEkle() {let ul=document.querySelector('#ucucul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ucucdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Yayın Sayısı</label>
<input type="number" name="ucucyayin[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ucucyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
function ucdortEkle() {let ul=document.querySelector('#ucdortul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ucdortdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Yayın Sayısı</label>
<input type="number" name="ucdortyayin[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ucdortyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
function ucbesEkle() {let ul=document.querySelector('#ucbesul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ucbesdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Yayın Sayısı</label>
<input type="number" name="ucbesyayin[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ucbesyazar[]" value="0" class="form-control w-100">
</div>

</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function ucaltiEkle() {let ul=document.querySelector('#ucaltiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ucaltidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Yayın Sayısı</label>
<input type="number" name="ucaltiyayin[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ucaltiyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
function ucyediEkle() {let ul=document.querySelector('#ucyediul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="ucyedidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Yayın Sayısı</label>
<input type="number" name="ucyediyayin[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="ucyediyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}







function dortbirEkle() {let ul=document.querySelector('#dortbirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="dortbirdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Kitap Sayısı</label>
<input type="number" name="dortbirkitap[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="dortbiryazar[]" value="0" class="form-control w-100">
</div>
</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function dortikiEkle() {let ul=document.querySelector('#dortikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="dortikidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for=""> Sayısı</label>
<input type="number" name="dortikikitap[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="dortikiyazar[]" value="0" class="form-control w-100">
</div>

</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function dortucEkle() {let ul=document.querySelector('#dortucul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="dortucdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Kitap Sayısı</label>
<input type="number" name="dortuckitap[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="dortucyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
function dortdortEkle() {let ul=document.querySelector('#dortdortul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="dortdortdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Kitap Sayısı</label>
<input type="number" name="dortdortkitap[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="dortdortyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}







function besbirEkle() {let ul=document.querySelector('#besbirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="besbirdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Atıf Sayısı</label>
<input type="number" name="besbiratif[]" value="0" class="form-control w-100">
</div>
</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function besikiEkle() {let ul=document.querySelector('#besikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="besikidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Atıf Sayısı</label>
<input type="number" name="besikiatif[]" value="0" class="form-control w-100">
</div>
</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function besucEkle() {let ul=document.querySelector('#besucul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="besucdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Atıf Sayısı</label>
<input type="number" name="besucatif[]" value="0" class="form-control w-100">
</div>


</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}



function altibirEkle() {let ul=document.querySelector('#altibirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="altibirdoktora[]" aria-label=".form-select-sm example">
       
        <option value="2">Doktora Sonrası</option>
    </select>
</div>
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="altibirdanismanlikseviye[]" aria-label=".form-select-sm example">
        <option value="1">Asıl Danışman</option>
        <option value="2">Eş Danışman</option>
    </select>
</div>
<div class="ms-2 col-md-2">
<label for="">Danışmanlık Sayısı</label>
<input type="number" name="altibirdanismanliksayi[]" value="0" class="form-control w-100">
</div>
</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function altiikiEkle() {let ul=document.querySelector('#altiikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="altiikidoktora[]" aria-label=".form-select-sm example">
      
        <option value="2">Doktora Sonrası</option>
    </select>
</div>
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="altiikidanismanlikseviye[]" aria-label=".form-select-sm example">
        <option value="1">Asıl Danışman</option>
        <option value="2">Eş Danışman</option>
    </select>
</div>
<div class="ms-2 col-md-2">
<label for="">Danışmanlık Sayısı</label>
<input type="number" name="altiikidanismanliksayi[]" value="0" class="form-control w-100">
</div>
</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}


function yedibirEkle() {let ul=document.querySelector('#yedibirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
                            <div class="col-md-2 ms-4">
                                <label for=""></label>
                                <select class="form-select form-select-lg mb-3" name="yedibirdoktora[]" aria-label=".form-select-sm example">
                                    <option value="1">Doktora Öncesi</option>
                                    <option value="2">Doktora Sonrası</option>
                                </select>
                            
                            </div>
                            <div class="ms-2 col-md-2">
                            <label for="">Proje Sayısı</label>
                            <input type="number" name="yedibirproje[]" value="0" class="form-control w-100">
                            </div>
                        </li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function yediikiEkle() {let ul=document.querySelector('#yediikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="yediikidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Proje Sayısı</label>
<input type="number" name="yediikiproje[]" value="0" class="form-control w-100">
</div>


</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function yediucEkle() {let ul=document.querySelector('#yediucul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="yediucdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Proje Sayısı</label>
<input type="number" name="yediucproje[]" value="0" class="form-control w-100">
</div>


</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function yedidortEkle() {let ul=document.querySelector('#yedidortul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="yedidortdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Proje Sayısı</label>
<input type="number" name="yedidortproje[]" value="0" class="form-control w-100">
</div>


</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}






function sekizbirEkle() {let ul=document.querySelector('#sekizbirul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="sekizbirdoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for="">Sayısı</label>
<input type="number" name="sekizbirsayi[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="sekizbiryazar[]" value="0" class="form-control w-100">
</div>

</li>
`;
liDom.classList.add('row'); ul.append(liDom);
}
function sekizikiEkle() {let ul=document.querySelector('#sekizikiul');
let liDom=document.createElement('li'); liDom.innerHTML=`
<li class="row">
<div class="col-md-2 ms-4">
    <label for=""></label>
    <select class="form-select form-select-lg mb-3" name="sekizikidoktora[]" aria-label=".form-select-sm example">
        <option value="1">Doktora Öncesi</option>
        <option value="2">Doktora Sonrası</option>
    </select>

</div>
<div class="ms-2 col-md-2">
<label for=""> Sayısı</label>
<input type="number" name="sekizikisayi[]" value="0" class="form-control w-100">
</div>
<div class="col-md-2">
    <label for="">Yazar Sayısı</label>
    <input type="number" name="sekizikiyazar[]" value="0" class="form-control w-100">
</div>

</li>

`;
liDom.classList.add('row'); ul.append(liDom);
}
