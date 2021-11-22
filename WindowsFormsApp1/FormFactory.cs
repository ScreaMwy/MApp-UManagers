using System.Windows.Forms;

namespace WinForm
{
    public class FormFactory
    {
        public static Form CreateFactory(int nodeIndex)
        {
            HideFromAll();
            switch (nodeIndex)
            {
                case 0:
                    if (_userManagerForm == null)
                    {
                        _userManagerForm = new UserManagerForm();
                    }
                    // _baseManagerForm?.Hide();
                    // _coefficientManagerForm?.Hide();
                    // _userAppraisalForm?.Hide();
                    // _userManagerForm?.Show();
                    _form = _userManagerForm;
                    break;
                case 1:
                    if (_baseManagerForm == null)
                    {
                        _baseManagerForm = new BaseManagerForm();
                    }
                    // _userManagerForm?.Hide();
                    // _coefficientManagerForm?.Hide();
                    // _userAppraisalForm?.Hide();
                    // _baseManagerForm?.Show();
                    _form = _baseManagerForm;
                    break;
                case 2:
                    if (_coefficientManagerForm == null)
                    {
                        _coefficientManagerForm = new CoefficientManagerForm();
                    }
                    // _userManagerForm?.Hide();
                    // _coefficientManagerForm?.Hide();
                    // _userAppraisalForm?.Hide();
                    // _coefficientManagerForm?.Show();
                    _form = _coefficientManagerForm;
                    break;
                case 3:
                    if (_userAppraisalForm == null)
                    {
                        _userAppraisalForm = new UserAppraisalForm();
                    }
                    // _userManagerForm?.Hide();
                    // _baseManagerForm?.Hide();
                    // _coefficientManagerForm?.Hide();
                    // _userAppraisalForm?.Show();
                    _form = _userAppraisalForm;
                    break;
                default:
                    break;
            }

            return _form;
        }

        public static void HideFromAll()
        {
            _userManagerForm?.Hide();
            _baseManagerForm?.Hide();
            _coefficientManagerForm?.Hide();
            _userAppraisalForm?.Hide();
        }
        
        private static Form _form;
        private static UserManagerForm _userManagerForm;
        private static BaseManagerForm _baseManagerForm;
        private static CoefficientManagerForm _coefficientManagerForm;
        private static UserAppraisalForm _userAppraisalForm;
    }
}