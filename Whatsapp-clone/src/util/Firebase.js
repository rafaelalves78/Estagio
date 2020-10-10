const firebase = require('firebase');
require('firebase/firestore');

export class Firebase{

    constructor(){

        this._config = {
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

        if(!window._initializedFirebase){
            firebase.initializeApp(this._config);
            firebase.analytics();

           

            window._initializedFirebase = true
        }    
  
    }

    static db(){
        return firebase.firestore();
    }

    static hd(){
        return firebase.storage();
    }

 

    initAuth(){

        return new Promise((s, f)=>{

            var provider = new firebase.auth.GoogleAuthProvider();
            

            firebase.auth().signInWithPopup(provider).then(function(result){

                var token = result.credential.accessToken;
                var user = result.user;

                s({
                    user,
                    token
                });

            }).catch(function (error) {

                f(error);           

            });           

        });     
    }
}