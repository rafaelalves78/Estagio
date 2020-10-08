const firebase = require('firebase');
require('firebase/firestore');

export class Firebase{

    constructor(){

        this._firebaseConfig = {
            apiKey: "AIzaSyDvKwI5g1fqTz-RRg4plACKoi3DJtYSFZk",
            authDomain: "whatsapp-clone-1a679.firebaseapp.com",
            databaseURL: "https://whatsapp-clone-1a679.firebaseio.com",
            projectId: "whatsapp-clone-1a679",
            storageBucket: "whatsapp-clone-1a679.appspot.com",
            messagingSenderId: "850179180474",
            appId: "1:850179180474:web:eab16d17d3e99caf3abf83",
            measurementId: "G-YV1KHPS6EH"
        }

        this.init()
    }

    init(){

        if(!this._initialized){
            firebase.initializeApp(this._firebaseConfig);
            firebase.analytics();

           

            this._initialized = true
        }    
  
    }

    static db(){
        return firebase.firestore();
    }

    static hd(){
        return firebase.storage();
    }

    initAuth(){

        return new Promise((resolve, reject)=>{

            let provider = new firebase.auth.GoogleAuthProvider();

            firebase.auth().signInWithPopup(provider).then(function (result) {

                let token = result.credential.accessToken;
                let user = result.user;

                resolve(user, token);

            }).catch(function (error) {

                reject(error);

            });

        });        

    }


}