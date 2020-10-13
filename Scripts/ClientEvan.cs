using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientEvan : MonoBehaviour
{
    IPosition m_currentPosition;

    public Dropdown StyleDropdown;
    public Dropdown RowDropdown;
    public Dropdown HeightDropdown;

    public Text PlayerPosition; //use for text mesh pro
    public bool Height;
    public bool Row;
    public bool Style;

    public string TextContainer;
    public Vector3 Center = new Vector3(150, 0, 0);

    private static IPosition GetPosition(PositionRequirements requirements)
    {
        PositionFactory factory = new PositionFactory(requirements);
        return factory.Create();
    }

    public void InputGather()
    {
        if (StyleDropdown.value == 1)
        {
            Style = true; //Offensive
            m_currentPosition = new sOffense(m_currentPosition);
            //Debug.Log("Points Scored: " + m_currentPosition.GetPoints());
        }
        else
        {
            Style = false; //Defensive
            m_currentPosition = new sDefense(m_currentPosition);
            //Debug.Log("Points Scored: " + m_currentPosition.GetPoints());
        }

        if (RowDropdown.value == 1)
        {
            Row = true; //Front
            m_currentPosition = new rFront(m_currentPosition);
            //Debug.Log("Points Scored: " + m_currentPosition.GetPoints());
        }
        else
        {
            Row = false; //Back
            m_currentPosition = new rBack(m_currentPosition);
            //Debug.Log("Points Scored: " + m_currentPosition.GetPoints());
        }

        if (HeightDropdown.value == 1)
        {
            Height = true; //Tall
            m_currentPosition = new hTall(m_currentPosition);
            //Debug.Log("Points Scored: " + m_currentPosition.GetPoints());
        }
        else
        {
            Height = false; //Short
            m_currentPosition = new hShort(m_currentPosition);
            //Debug.Log("Points Scored: " + m_currentPosition.GetPoints());
        }

            PositionRequirements requirements = new PositionRequirements();
            requirements.Height = Height;
            requirements.Row = Row;
            requirements.Style = Style;

            IPosition p = GetPosition(requirements);
            PlayerPosition.text = p.ToString() + "\nPoints Scored: " + p.GetPoints();

            //TextContainer = p.ToString();
            //TextContainer += "_3D";
            //Instantiate(Resources.Load(TextContainer), Center, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}
