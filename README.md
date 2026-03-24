# 🚀 Smart Support AI

## 📌 Description

**Smart Support AI** est une plateforme intelligente de gestion de support technique multi-tenant, permettant de gérer :

* 👤 les utilisateurs (admin, agent, client)
* 🎫 les tickets de support
* 💬 les échanges (messagerie interne)
* 🔔 les notifications
* 🤖 une future intégration d’un chatbot IA

Ce projet est développé avec une architecture **Clean Architecture** afin d'assurer :

* 🔹 scalabilité
* 🔹 maintenabilité
* 🔹 séparation des responsabilités
* 🔹 qualité de code (niveau production)

---

## 🧱 Architecture

Le projet est structuré en **Clean Architecture** :

```
SmartSupportAI/
│
├── src/
│   ├── SmartSupportAI.Domain         # Entités métier
│   ├── SmartSupportAI.Application    # Logique métier, services, DTOs
│   ├── SmartSupportAI.Infrastructure # Accès aux données (EF Core, PostgreSQL)
│   ├── SmartSupportAI.Api            # API REST (Controllers, JWT)
│
├── SmartSupportAI.sln
```

---

## ⚙️ Technologies utilisées

* .NET 8 Web API
* Entity Framework Core
* PostgreSQL
* JWT Authentication
* Clean Architecture
* BCrypt (hash password)

---

## 🔐 Authentification

Le système utilise **JWT (JSON Web Token)** pour sécuriser l'accès à l'API.

Fonctionnalités :

* ✅ Register
* ✅ Login
* ✅ Génération de token
* 🔒 Sécurisation des endpoints

---

## 🏢 Multi-Tenant

Chaque entité est liée à un `TenantId` permettant :

* Isolation des données
* Gestion SaaS multi-clients
* Scalabilité

---

## 🗄️ Base de données

* PostgreSQL
* EF Core Migrations

---

## 🚀 Installation

### 1️⃣ Cloner le projet

```bash
git clone https://github.com/Elidrissi12/SmartSupportAI.git
cd SmartSupportAI
```

---

### 2️⃣ Configurer la base de données

Dans `appsettings.json` :

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=smart_support_ai;Username=postgres;Password=1234"
}
```

---

### 3️⃣ Appliquer les migrations

```bash
dotnet ef database update -p src/SmartSupportAI.Infrastructure -s src/SmartSupportAI.Api
```

---

### 4️⃣ Lancer le projet

```bash
dotnet run --project src/SmartSupportAI.Api
```

---

## 📡 API Endpoints (Auth)

### 🔹 Register

```
POST /api/auth/register
```

### 🔹 Login

```
POST /api/auth/login
```

---

## 📈 Roadmap

* [x] Clean Architecture setup
* [x] Authentification JWT
* [x] Base de données PostgreSQL
* [ ] CRUD Tickets
* [ ] Système de messagerie
* [ ] Notifications
* [ ] Multi-tenant avancé
* [ ] Intégration Chatbot IA 🤖

---

## 👨‍💻 Auteur

**Zaki El Idrissi Abdallah**
📍 Marrakech, Maroc
📧 [zakielidrissiabdallah@gmail.com](mailto:zakielidrissiabdallah@gmail.com)

---

## 💡 Objectif

Ce projet est développé dans le cadre d’un **Projet de Fin d’Études (PFE)** avec une vision professionnelle orientée :

* SaaS
* Cloud (Azure)
* DevOps
* IA

---

## ⭐ Contribution

Les contributions sont les bienvenues !

---

## 📜 Licence

Projet éducatif – utilisation libre
