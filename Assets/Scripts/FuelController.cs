using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
//      FuelController controller = new FuelController();
//   controller.AddFuel(50); // Pass the correct arguments.

    public static FuelController instance;

    [SerializeField] private Image _fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float _fuelDrainSpeed = 1f;
    [SerializeField] private float _maxFuelAmount = 100f;

    [SerializeField] private Gradient _fuelGradient;

    private float _currentFuelAmount;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentFuelAmount = _maxFuelAmount;
        UpdateUI();
    }

    private void Update()
    {
        _currentFuelAmount -= Time.deltaTime * _fuelDrainSpeed;
        UpdateUI();
    }

    private void UpdateUI()
    {
        _fuelImage.fillAmount = (_currentFuelAmount / _maxFuelAmount);
        _fuelImage.color = _fuelGradient.Evaluate(_fuelImage.fillAmount);
    }
    public void FillFuel()
    {
        _currentFuelAmount=_maxFuelAmount;
        UpdateUI();
    }
    public void AddFuel(float amount)
    {
        _currentFuelAmount=Mathf.Min(_currentFuelAmount+amount,_maxFuelAmount);
        UpdateUI();
    }

//     FuelController controller = new FuelController();
// controller.AddFuel(50); // Pass the correct arguments.


}
