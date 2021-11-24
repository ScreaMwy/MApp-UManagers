using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForm
{
    public class FormFactory
    {
        // 创建窗体创库，获取窗体的单例对象
        public static Form CreateFactory(int nodeIndex)
        {
            HideFromAll();
            switch (nodeIndex)
            {
                case 0:
                    if (_userManagerForm == null)
                    {
                        _userManagerForm = new UserManagerForm();
                        _forms.Add(_userManagerForm);
                    }
                    _form = _userManagerForm;
                    break;
                    
                case 1:
                    if (_baseManagerForm == null)
                    {
                        _baseManagerForm = new BaseManagerForm();
                        _forms.Add(_baseManagerForm);
                    }
                    _form = _baseManagerForm;
                    break;

                case 2:
                    if (_coefficientManagerForm == null)
                    {
                        _coefficientManagerForm = new CoefficientManagerForm();
                        _forms.Add(_coefficientManagerForm);
                    }
                    _form = _coefficientManagerForm;
                    break;

                case 3:
                    if (_userAppraisalForm == null)
                    {
                        _userAppraisalForm = new UserAppraisalForm();
                        _forms.Add(_userAppraisalForm);
                    }
                    _form = _userAppraisalForm;
                    break;

                default:
                    break;
            }

            return _form;
        }

        public static void HideFromAll()
        {
            /*_userManagerForm?.Hide();
            _baseManagerForm?.Hide();
            _coefficientManagerForm?.Hide();
            _userAppraisalForm?.Hide();*/
            foreach (Form form in _forms)
            {
                form.Hide();
            }
        }
        
        private static Form _form;
        private static UserManagerForm _userManagerForm;
        private static BaseManagerForm _baseManagerForm;
        private static CoefficientManagerForm _coefficientManagerForm;
        private static UserAppraisalForm _userAppraisalForm;
        private static List<Form> _forms = new List<Form>();
    }
}