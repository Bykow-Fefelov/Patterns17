package cw.gui.form;

import java.util.HashMap;
import java.util.List;

// ��������� ��� �������� �������, �� �������� ����� ���� ��������� �����
public interface IEditable {
	
	public void addFormFields(List<FieldData> list);
	
	public void acceptValues(HashMap<String, Object> map);
	
}
