// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuDefinitionMaint_Environment
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
  public class PortalMenuDefinitionMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Portal Menu Definition", "PortalMenuDefinitionChanges", false, false, false, "PortalMenuDefinitionChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_Environment_ObjectChanges")]
    protected PortalMenuDefinitionChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_Environment_ObjectToChange")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface in Liberty.", "PortalMenuDefinition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface in Liberty.", "PortalMenuDefinition", false, false, false, "NamedObjectRef", 1052437, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_Environment_TargetMenu")]
    protected Environment _TargetMenu;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionMaint_Environment_ObjectListInquiry")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface in Liberty.", "PortalMenuDefinition", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;

    public PortalMenuDefinitionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PortalMenuDefinitionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public Environment TargetMenu
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetMenu), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetMenu));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
