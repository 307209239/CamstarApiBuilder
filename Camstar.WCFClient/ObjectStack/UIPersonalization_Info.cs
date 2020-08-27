// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalization_Info
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
  public class UIPersonalization_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Info_ESigHistoryDetails")]
    protected Info _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Info_Content")]
    protected Info _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Info_WorkspaceId")]
    protected Info _WorkspaceId;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Info_ChangeHistory")]
    protected ChangeHistory_Info _ChangeHistory;

    public Info ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Content));
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

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public ChangeHistory_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }
  }
}
