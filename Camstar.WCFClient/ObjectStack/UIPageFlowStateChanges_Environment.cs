// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowStateChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UIPageFlowStateChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("LongString", "", false, false, false, "String", 1051505, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_Content")]
    protected Environment _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_PageFlowActivities")]
    [Metadata("UI PageFlow Activity", "UIPageFlowActivityChanges", false, false, false, "UIPageFlowActivityChanges", 1051507, false, true, false, null)]
    protected UIPageFlowActivityChanges_Environment _PageFlowActivities;
    [Metadata("UI PageFlow State", "UIPageFlowStateChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("UI PageFlow State", "UIPageFlowState", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("UI Provider Component Name which is typically a generated GUID", "", false, true, false, "String", 1051504, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_QualityObjectType")]
    [Metadata("Generic String", "", false, false, false, "String", 1051781, false, false, false, null)]
    protected Environment _QualityObjectType;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_Owner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051780, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowStateChanges_Environment_QualityObjectName")]
    protected Environment _QualityObjectName;

    public Environment Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Content));
      }
    }

    public UIPageFlowActivityChanges_Environment PageFlowActivities
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowActivities), (object) value);
      }
      get
      {
        return (UIPageFlowActivityChanges_Environment) this.PropertyGet(nameof (PageFlowActivities));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment QualityObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObjectType));
      }
    }

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }

    public Environment QualityObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObjectName));
      }
    }
  }
}
