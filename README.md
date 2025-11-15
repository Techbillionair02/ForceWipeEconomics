# ForceWipeEconomics  
### Automatically wipe Economics balances on Rust's monthly force wipe  
_Revised and maintained by **Regime Gaming**_

---

## 🧩 Overview  
**ForceWipeEconomics** is a lightweight Rust plugin that automatically wipes all player balances stored by the **Economics** plugin during Rust’s official force wipe — the **first Thursday of every month**.

No commands needed.  
No admin intervention.  
No forgotten wipes.  
Economy resets itself automatically on wipe day.

This plugin was developed and refined for **Regime Gaming** to keep monthly wipe cycles clean, fair, and fully automated.

---

## 🚀 Features  
- ✔️ Automatically detects Rust’s **first Thursday** force wipe  
- ✔️ Wipes all balances stored in **Economics**  
- ✔️ Runs **one time** per server boot  
- ✔️ Zero configuration — plug & play  
- ✔️ Safe checks to prevent double-wipes  
- ✔️ Fully compatible with any server using `Economics`

---

## 📦 Installation  
1. Download `ForceWipeEconomics.cs`  
2. Place it in your server’s `oxide/plugins/` folder  
3. Ensure you have the **Economics** plugin installed  
4. Restart the server  
5. Done — it will auto-wipe on every force wipe day

---

## 🛠 How It Works  
Rust force wipes always fall on:

**→ The first Thursday of every month**

The plugin checks this automatically during server initialization:

- If today *is* the force wipe → it wipes all Economics balances  
- If it’s not → plugin does nothing  
- Ensures wipe runs **once per boot** only

---

## 📅 Why Monthly Wipes Matter  
Server economies quickly inflate as wipes progress.  
Resetting balances monthly keeps gameplay:

- Fair  
- Balanced  
- Competitive  
- Rewards active players each wipe cycle

This helps maintain a healthy long-term player base.

---

## 📝 Configuration  
There is **no configuration file**.  
The logic is fully automated based on Rust’s wipe schedule.

---

## 🔧 Developer Notes  
This plugin calls:

```csharp
Economics.Call("WipeBalance");
