using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TankSelector : MonoBehaviour {

	public GameObject currentTank;
	public GameObject currentInfo;
	public GameObject currentEspecs;

	public Text currentTankName;
	public Text currentTankDescription;
	public Button nextButton;

	public Text currentSpeed;
	public Text currentAgility;
	public Text currentForce;
	public Text currentDurability;

	public static string currentTankSelected;
	
	public void selectTank(GameObject tank) {
		currentTank.SetActive (false);
		currentTank = tank;
		currentTank.SetActive (true);

		currentInfo.SetActive (true);
		currentEspecs.SetActive (true);
		nextButton.interactable = true;

		if (tank.name.Equals ("Cromwell")) {
			currentTankName.text = "Cromwell Mk VIII (A27M)";
			currentTankDescription.text = "O Cromwell Mk VIII (A27M) foi um \"Tanque Cruzador\" da Segunda Guerra Mundial das forças do exército do Reino Unido, e foi o modelo de maior sucesso entre os tanques cruzadores. Ele foi o primeiro tanque do arsenal britânico a usar suas armas para outros propósitos, velocidade alta e blindagem melhorado. Foi o modelo mais usado durante a guerra, e depois veio a substituir o Sherman por algumas unidades. Seu projeto formou a base do formidável Comet I (A34).";
			currentSpeed.text = "DDDDD";
			currentAgility.text = "DDDD";
			currentForce.text = "DD";
			currentDurability.text = "DDD";
			currentTankSelected = "Cromwell"; 
		} else if (tank.name.Equals ("M4A3")) {
			currentTankName.text = "M4A3 Sherman";
			currentTankDescription.text = "O M4A3, Sherman «Firefly» foi o mais poderoso de todos os tanques Sherman ao serviço durante a II Guerra Mundial. De entre todos os modelos do tipo, o «Firefly» era o único que os proprios alemães afirmavam ser de temer. A afirmação permite ter uma ideia da opinião geral que os alemães tinham dos tanques utilizados pelos países aliados, que na sua generalidade eram inferiores aos seus.";
			currentSpeed.text = "DDDD";
			currentAgility.text = "DDDD";
			currentForce.text = "DDD";
			currentDurability.text = "DDD";
			currentTankSelected = "M4A3"; 
		} else if (tank.name.Equals ("M4E8")) {
			currentTankName.text = "M4E8";
			currentTankDescription.text = "O M4E8, foi o mais poderoso de todos os tanques Sherman ao serviço durante a II Guerra Mundial. De entre todos os modelos do tipo, o «Firefly» era o único que os proprios alemães afirmavam ser de temer. A afirmação permite ter uma ideia da opinião geral que os alemães tinham dos tanques utilizados pelos países aliados, que na sua generalidade eram inferiores aos seus.";
			currentSpeed.text = "DDDD";
			currentAgility.text = "DDD";
			currentForce.text = "DD";
			currentDurability.text = "DDD";
			currentTankSelected = "M4E8"; 
		} else if (tank.name.Equals ("M24")) {
			currentTankName.text = "M24 Chaffee";
			currentTankDescription.text = "O tanque leve M24 Chaffee foi um tanque de uso dos Estados Unidos na Segunda Guerra Mundial e em conflitos pós-guerra como a Guerra da Coréia, sob o serviço britânico recebeu o codinome Chaffee. Foi utilizado pelo exército português.";
			currentSpeed.text = "DD";
			currentAgility.text = "D";
			currentForce.text = "DDD";
			currentDurability.text = "DDDDD";
			currentTankSelected = "M24"; 
		} else if (tank.name.Equals ("Panther")) {
			currentTankName.text = "Sd.Kfz. 171 Panzerkampfwagen V Panther";
			currentTankDescription.text = "O Sd.Kfz. 171 Panzerkampfwagen V Panther foi um carro de combate alemão empregado na Segunda Guerra Mundial. Foi projetado para substituir os PzKpfw III e PzKpfw IV, para que a Panzerwaffe pudesse superar os carros de combate russos T-34/76 e KV, e igualar-se aos mais recentes veículos aliados.";
			currentSpeed.text = "DDDD";
			currentAgility.text = "DDD";
			currentForce.text = "DDDD";
			currentDurability.text = "DD";
			currentTankSelected = "Panther"; 
		} else if (tank.name.Equals ("stugIII")) {
			currentTankName.text = "Sturmgeschütz III";
			currentTankDescription.text = "O canhão de guerra Sd.Kfz. 142 Sturmgeschütz III (StuG III) foi um dos veículos blindados mais produzidos pela Alemanha durante a Segunda Guerra Mundial. Ele foi baseado nos chassis do Panzer III, que levava um canhão de 37 mm e depois um de 50 mm, que se comprovou obsoleto com o surgimento do KV-1 e do T-34 soviético, era armado com um canhão de cano curto de 75 mm para apoio da infantaria, o mesmo usado nos primeiros Panzer IV.";
			currentSpeed.text = "DDDDD";
			currentAgility.text = "DDDDD";
			currentForce.text = "DDD";
			currentDurability.text = "D";
			currentTankSelected = "STUGIII"; 
		} else if (tank.name.Equals ("T34-85")) {
			currentTankName.text = "T34-85";
			currentTankDescription.text = "O T-34-85 foi o sucessor do revolucionário T-34, o tanque médio simbolo da resistência soviética durante a ofensiva alemã. Sua nova torre, com 3 tripulantes, cúpula para o comandante e um novo canhão mais poderoso foi uma resposta ao Panther e Tiger das forças do eixo, que possuíam blindagem demasiadamente espessa para serem derrotadas a uma distancia segura pelo T-34.";
			currentSpeed.text = "DDD";
			currentAgility.text = "DDD";
			currentForce.text = "DDDD";
			currentDurability.text = "DDDDD";
			currentTankSelected = "T34-85"; 
		}
	}

	public void hideObject() {
		currentTank.SetActive (false);
	}
}
