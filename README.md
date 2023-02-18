# How To Securely Store And Load Secrets Using Azure Key Vault .NET Core

Using Azure Key Vault Service allows for centralization and protection of your application secrets, certificates but also encryption keys for Virtual Machines.



## Connect .Net Core to Azure Key Vault
https://www.youtube.com/watch?v=6l_kpygO0Ic


- Create Web API project

- Create **Storage Account**

- Create Queue 
<img src="/pictures/queue.png" title="queue"  width="800">

- Get the connection queue connection string
<img src="/pictures/connection_string.png" title="connection string"  width="500">

- Play the app :
<img src="/pictures/app.png" title="app"  width="800">

- See the result in the queue :
<img src="/pictures/app2.png" title="app"  width="800">

- Create a key vault :
<img src="/pictures/queue_key_vault.png" title="queue key vault"  width="500">

- Create secret for the queue connection string :
<img src="/pictures/queue_conn_string.png" title="queue connection string"  width="500">

- Grab the key vault url :
<img src="/pictures/kv_url.png" title="key vault url"  width="800">

- Make sure the app is still working
<img src="/pictures/coucou.png" title="last test"  width="800">


### 



## Azure Key Vault - Secure secrets, keys and certificates

1. Key vault

- Create **Key Vault**
<img src="/pictures/key_vault.png" title="key_vault"  width="500">

- Generate a secret
<img src="/pictures/secret.png" title="secret"  width="500">


2. Logic App

- Create **Logic App**
<img src="/pictures/logic_app.png" title="logic_app"  width="500">

- Create **Managed Identity**
<img src="/pictures/managed_identity.png" title="managed_identity"  width="500">


3. Key vault

- Create an **access policy**
<img src="/pictures/access_policy.png" title="access policy"  width="500">

- Create an **Access Policy** for the **Logic App**
<img src="/pictures/logic_app_access_policy.png" title="logic app access policy"  width="500">

- Grab the **Secret Identifier**
<img src="/pictures/secret_identifier.png" title="secret identifier"  width="500">

- Add HTTP to the **Logic App**
<img src="/pictures/http.png" title="logic app http"  width="800">

- See the result :
<img src="/pictures/http_success.png" title="http success"  width="800">








https://www.youtube.com/watch?v=b21EQvfjvHc


