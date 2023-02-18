# How To Securely Store And Load Secrets Using Azure Key Vault .NET Core

Using Azure Key Vault Service allows for centralization and protection of your application secrets, certificates but also encryption keys for Virtual Machines.



## Connect .Net Core to Azure Key Vault
https://www.youtube.com/watch?v=6l_kpygO0Ic


- Create Web API project


- Create Web API project
<img src="/pictures/key_vault.png" title="key_vault"  width="500">



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


