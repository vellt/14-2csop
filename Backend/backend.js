const express= require('express');
const cors = require('cors');
const mysql = require('mysql');

let port =3000;
let host='localhost';

const app= express();
app.use(cors());
app.use(express.json());

const connection= mysql.createConnection({
    host:host,
    user:'root',
    password: '',
    database:'nik2024',
});

app.get('/idoutazok', (req, res)=>{
    connection.query('SELECT id, vezeteknev, keresztnev, neme, DATE_FORMAT(szuletesi_datum,"%Y-%m-%d") as szuletesi_datum, kep  FROM idoutazok', (err, results)=>{
        if(err){
            console.log(err);
            res.send("hiba");
        }else{
            console.log(results);
            res.send(results);
        }
    });
});

app.get('/idohurkok', (req, res)=>{
    connection.query('SELECT * FROM idohurkok', (err, results)=>{
        if(err){
            console.log(err);
            res.send("hiba");
        }else{
            console.log(results);
            res.send(results);
        }
    });
});

app.get('/idougrasok', (req, res)=>{
    connection.query('SELECT * FROM idougrasok', (err, results)=>{
        if(err){
            console.log(err);
            res.send("hiba");
        }else{
            console.log(results);
            res.send(results);
        }
    });
});

app.listen(port, host, ()=>{
    console.log(`ip: http://${host}:${port}`);
});