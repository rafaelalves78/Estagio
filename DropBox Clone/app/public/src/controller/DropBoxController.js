class DropBoxController{

    constructor(){

        this.btnSendFileEl = document.querySelector('#btn-send-file');
        this.inputFilesEl = document.querySelector('#files');
        this.initEvent();

    }


    initEvent(){

        this.btnSendFileEl.addEventListener('click', event =>{
            
            this.inputFilesEl.click();


        } )
    
    }

}

