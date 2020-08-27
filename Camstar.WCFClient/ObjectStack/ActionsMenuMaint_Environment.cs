// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuMaint_Environment
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
  public class ActionsMenuMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Actions menus are used to create set of items linked to UIVirtualPages.", "ActionsMenu", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuMaint_Environment_ObjectToChange")]
    [Metadata("Actions menus are used to create set of items linked to UIVirtualPages.", "ActionsMenu", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuMaint_Environment_ObjectChanges")]
    [Metadata("Actions menus are used to create set of items linked to UIVirtualPages.", "ActionsMenuChanges", false, false, false, "ActionsMenuChanges", 1048873, true, false, false, null)]
    protected ActionsMenuChanges_Environment _ObjectChanges;

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

    public ActionsMenuChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActionsMenuChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
