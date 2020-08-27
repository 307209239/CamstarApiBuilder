// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteStepChanges_Environment
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
  public class RouteStepChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Environment_ListItemToChange")]
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStepChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, false, "NamedSubentityRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic String", "", false, false, false, "String", 1049916, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Environment_ERPOperation")]
    protected Environment _ERPOperation;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Environment_Sequence")]
    [Metadata("Generic String", "", false, false, false, "String", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050258, false, false, false, null)]
    protected new Environment _Name;

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

    public Environment ERPOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPOperation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPOperation));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
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
  }
}
