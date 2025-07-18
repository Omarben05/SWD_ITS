package services;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import model.Automobile;
import repos.AutomobiliDAO;


public class AutomobileService {

	
		
		private AutomobiliDAO dao = new AutomobiliDAO();
		
		public List<Automobile> getAutomobili() {
			
			Map<Integer, Automobile> automobili = dao.getAutomobili();
			automobili.values();
			List<Automobile> auto = new ArrayList<>();
			
			return auto; 
		
	}
}
