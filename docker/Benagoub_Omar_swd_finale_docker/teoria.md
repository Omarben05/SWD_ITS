# Omar Benagoub 29/07/2025 - Software Developer Containers - Docker VERIFICA FINE UF

## Parte 1 – Domande Teoriche

### 1. Che cos'è Docker e quali benefici porta nello sviluppo e nel rilascio di applicazioni?

Docker è una piattaforma di containerizzazione che permette di impacchettare applicazioni e le loro dipendenze in container leggeri e portabili. I principali benefici includono: **portabilità** (l'applicazione funziona identicamente su qualsiasi ambiente), **isolamento** (ogni container ha il proprio ambiente isolato), **efficienza** (condivisione del kernel dell'host), **scalabilità** (facile replicazione e gestione dei container), e **consistency** (eliminazione del problema "funziona sulla mia macchina").

### 2. Quali componenti sono necessari per creare e avviare un container Docker funzionante?

I componenti essenziali sono: **Dockerfile** (file di configurazione che definisce come costruire l'immagine), **immagine Docker** (template immutabile creato dal Dockerfile), **Docker Engine** (runtime che gestisce i container), e opzionalmente un **registry** (per scaricare immagini base o condividere le proprie). Il processo prevede la build dell'immagine dal Dockerfile e successivamente l'esecuzione del container dall'immagine.

### 3. Quali vantaggi offre la containerizzazione rispetto al deploy su macchine fisiche o VM tradizionali?

La containerizzazione offre **maggiore efficienza** (condivisione del kernel invece di OS completi), **avvio più rapido** (secondi vs minuti), **utilizzo ottimale delle risorse** (overhead minimo), **portabilità completa** (stesso comportamento su qualsiasi infrastruttura), **isolamento sicuro** senza il peso di hypervisor, e **gestione semplificata** delle dipendenze. Inoltre, permette una **densità maggiore** di applicazioni per server fisico.

### 4. Descrivi i passi principali per eseguire un'applicazione Python all'interno di un container Docker.

I passi sono: 1) **Creare un Dockerfile** partendo da un'immagine Python base (es. python:3.10), 2) **Copiare il codice** e i file requirements.txt nel container, 3) **Installare le dipendenze** con `pip install -r requirements.txt`, 4) **Esporre la porta** necessaria con EXPOSE, 5) **Definire il comando di avvio** con CMD o ENTRYPOINT, 6) **Buildare l'immagine** con `docker build`, 7) **Eseguire il container** con `docker run` mappando le porte necessarie.

### 5. Come si crea un container Docker per eseguire un'applicazione Java e quali particolarità vanno considerate?

Per Java occorre: **scegliere un'immagine JRE/JDK** appropriata (es. openjdk:11), **copiare il JAR** dell'applicazione, **esporre le porte** necessarie, e **configurare la JVM** con parametri ottimali (memoria heap, garbage collector). Particolarità: Java richiede più memoria, attenzione ai **limiti di memoria del container** (JVM potrebbe non riconoscerli correttamente), gestione delle **variabili d'ambiente** per configurazione, e considerare l'uso di **immagini Alpine** per ridurre le dimensioni.

### 6. Come vengono gestite le connessioni di rete tra container e quali accorgimenti sono necessari per garantire la comunicazione tra servizi?

Docker crea **reti virtuali** dove i container possono comunicare usando i **nomi dei servizi** come hostname. Gli accorgimenti includono: definire **reti custom** per isolare i servizi, utilizzare **Docker Compose** per gestione automatica della rete, **esporre solo le porte necessarie** all'host, configurare **health checks** per verificare la disponibilità dei servizi, e utilizzare **service discovery** per connessioni dinamiche tra container.

### 7. Spiega cosa significa esporre una porta di un container e perché è un passaggio cruciale nel deploy.

Esporre una porta significa **mappare una porta del container** su una porta dell'host, rendendo il servizio accessibile dall'esterno. È cruciale perché: i container sono **isolati per default**, senza mapping le applicazioni non sarebbero raggiungibili, permette di **controllare l'accesso** ai servizi, consente **load balancing** e **reverse proxy**, e facilita l'**integrazione con sistemi esterni**. Si usa la sintastica `-p host_port:container_port`.

### 8. In che modo il layering del file system influisce sulle prestazioni e sulla gestione delle immagini Docker?

Il **sistema a layer** permette di **condividere parti comuni** tra immagini (efficienza storage), **cache intelligente** durante la build (rebuild solo dei layer modificati), **ottimizzazione della rete** (download solo dei layer mancanti), e **versioning incrementale**. Per le prestazioni: ordinare i comandi dal **meno al più variabile**, minimizzare il **numero di layer**, utilizzare **.dockerignore** per escludere file non necessari, e sfruttare **multi-stage builds** per immagini finali più leggere.

### 9. Quando conviene usare un bind mount e quando invece un volume? Fornisci un esempio per ciascun caso.

**Bind mount**: quando serve accesso diretto ai file dell'host, utile per **sviluppo** (modifiche real-time al codice) - esempio: `-v /host/src:/app/src` per hot-reload del codice sorgente. **Volume**: per **dati persistenti gestiti da Docker**, migliori performance e portabilità - esempio: `-v db_data:/var/lib/postgresql/data` per database che deve mantenere i dati tra restart e essere facilmente backup/restore.

### 10. Perché Docker Compose semplifica la gestione di applicazioni multi-servizio rispetto all'avvio manuale dei singoli container?

Docker Compose permette **definizione dichiarativa** di tutti i servizi in un unico file YAML, **gestione automatica delle reti** tra servizi, **orchestrazione delle dipendenze** (ordine di avvio), **condivisione semplificata di volumi**, **scaling facilitato** dei servizi, e **comandi unificati** (up/down/restart per tutta l'applicazione). Elimina la complessità di ricordare multiple configurazioni di `docker run` e garantisce **consistenza tra ambienti**.

### 11. Qual è il ruolo di Kubernetes in un'infrastruttura basata su container e quali problemi risolve rispetto a Docker standalone?

Kubernetes è un **orchestratore di container** che gestisce cluster di macchine per **deployment automatizzato**, **scaling dinamico**, **load balancing**, **service discovery**, **rolling updates**, **self-healing** (riavvio automatico container falliti), e **gestione delle risorse**. Risolve: **alta disponibilità**, **distribuzione su più nodi**, **gestione automatica dei fallimenti**, **scaling orizzontale intelligente**, e **networking complesso** tra datacenter multipli.

### 12. In quali scenari complessi Kubernetes può essere più indicato rispetto a Docker Compose?

Kubernetes è preferibile per: **ambienti di produzione enterprise** con alta disponibilità, **applicazioni che richiedono scaling automatico** basato su metriche, **deployment multi-region** o multi-cloud, **microservizi complessi** con centinaia di servizi, **CI/CD avanzate** con blue-green deployment, **gestione di segreti e configurazioni** sensibili, e quando serve **monitoring e logging centralizzato**. Docker Compose resta ideale per sviluppo locale e applicazioni semplici.

### 13. Cita due esempi concreti in cui Docker può migliorare il ciclo di sviluppo e rilascio di un progetto software.

**Esempio 1 - Team di sviluppo**: Docker garantisce che tutti i developer abbiano **ambiente identico** (stesse versioni di DB, runtime, dipendenze), eliminando bug dovuti a differenze ambientali e riducendo il tempo di onboarding di nuovi membri del team da giorni a minuti.

**Esempio 2 - Pipeline CI/CD**: Docker permette **test automatizzati** in ambienti isolati identici alla produzione, **deployment zero-downtime** tramite container swap, **rollback immediato** alle versioni precedenti, e **scaling automatico** basato sul traffico, riducendo drasticamente i rischi di rilascio e i tempi di deployment.

---
**Utilizzo di LLM - GitHub Copilot**: L'assistente AI è stato utilizzato principalmente come strumento di verifica e ampliamento delle conoscenze già acquisite durante il percorso formativo. Le competenze teoriche su Docker, containerizzazione e orchestrazione erano già consolidate attraverso lo studio e la pratica laboratoriale. Copilot ha supportato nell'organizzazione strutturale delle risposte, nella verifica della terminologia tecnica appropriata e nell'arricchimento di alcuni concetti con esempi pratici, confermando e integrando le conoscenze preesistenti piuttosto che sostituirle. L'approccio è stato di apprendimento attivo, utilizzando l'AI per validare e perfezionare la comprensione personale dei concetti.

---

## Parte 2 – Esercizi Pratici su Docker

### Esercizio 1 – Container con output e timestamp

**Contenuto del Dockerfile:**
```dockerfile
FROM python:3.10-alpine

COPY script.py /app/script.py

WORKDIR /app

CMD ["python", "script.py"]
```

**Script utilizzato (parte2/script.py):**
```python
import datetime

current_time = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
print(f"hello fine UF - {current_time}")
```

**Comandi di build e run:**
```powershell
# Build dell'immagine
docker build -t hello-uf .

# Esecuzione del container
docker run hello-uf
```

**Output del container:**
```
hello fine UF - 2025-07-29 [timestamp dell'esecuzione]
```