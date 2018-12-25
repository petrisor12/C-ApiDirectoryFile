# c-ApiDirectoryFile
Il progetto crea una api avendo come dati di input la structura di un directory interna,una volta exposta la api, dal progetto console si recuperano 
i dati per essere visualizzati sul terminale
Il progetto in Visual Studio comprende 3 sottoprogetti:
1.Dati (qui si trovano la mapatura dei file in Models-FileModel e FolderModel
 IDATA e Dati servono per il recupero delle informazioni dalla connectione specificata in appsettings.json)
 Sono stati utilizzati i pachetti nuget Microsoft.Extensions.Configuration.Abstractions e Newtonsoft.json (questo ultimo per la serializzatione e deserializzatione dei json)
 2.Api che riferenzia Dati ed expone le chiamate in DatiControler; il colegamento ai dati è fatto tramite "services.AddSingleton<IDati, DatiFolder>();" 
 presente in startup.cs
 Una volta realizzati i primi due progetti deve essere fatto run al progetto per exporere la get
 3.Console - questo progetto recupera i dati dalle api exposte dal secondo progetto tramite metodi asincroni e expone i dati al terminale
 
 
