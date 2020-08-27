// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalizationMaint_Environment
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
  public class UIPersonalizationMaint_Environment : SubentityMaintenance_Environment
  {
    [Metadata("UI Personalization data", "UIPersonalization", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Environment_ObjectChanges")]
    [Metadata("UI Personalization data", "UIPersonalizationChanges", false, false, false, "UIPersonalizationChanges", 1048873, true, false, false, null)]
    protected UIPersonalizationChanges_Environment _ObjectChanges;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1050488, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Environment_ParentDataObject")]
    protected new Environment _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Environment_ContentAction")]
    [Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, false, "Integer", 1052339, false, false, false, null)]
    protected Environment _ContentAction;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Environment_WorkspaceId")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053272, false, false, false, null)]
    protected Environment _WorkspaceId;

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

    public UIPersonalizationChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public Environment ContentAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContentAction));
      }
    }

    public Environment WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkspaceId));
      }
    }
  }
}
