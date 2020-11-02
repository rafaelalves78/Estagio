
//CRIANDO COLEÇAO OBJETOS == VETORES OU ARREY
const classA = [
    {
        name: "Rafael",
        note: 6.8
    },
    {
        name: "Cerli",
        note: 10.0
    },
    {
        name: "Ricardo",
        note: 9.9
    }
]



function marcarComoReprovdo(student) {
    student.disapproved = false
   
    if (student.note < 7) {
        student.disapproved = true
    }

}

function enviarMensagemdisapproved(student) {
    if (student.disapproved) {
        console.log(`O student ${student.name} está disapproved`)
    }
}
function studentdisapproved(students) {
    for (let student of students) {
        marcarComoReprovdo(student)
        enviarMensagemdisapproved(student)
    }
}
studentdisapproved(classA)




