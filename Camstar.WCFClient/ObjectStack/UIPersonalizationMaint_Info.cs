// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalizationMaint_Info
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
  public class UIPersonalizationMaint_Info : SubentityMaintenance_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Info_ObjectChanges")]
    protected UIPersonalizationChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Info_ParentDataObject")]
    protected new Info _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Info_ContentAction")]
    protected Info _ContentAction;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationMaint_Info_WorkspaceId")]
    protected Info _WorkspaceId;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPersonalizationChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UIPersonalizationChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Info ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public Info ContentAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContentAction));
      }
    }

    public Info WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkspaceId));
      }
    }
  }
}
