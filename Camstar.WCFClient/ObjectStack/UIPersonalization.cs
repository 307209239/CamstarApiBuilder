// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalization
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
  public class UIPersonalization : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_ESigHistoryDetails")]
    protected SubentityRef[] _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Content")]
    protected Primitive<string> _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_WorkspaceId")]
    protected Primitive<int> _WorkspaceId;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_ChangeHistory")]
    protected ChangeHistory _ChangeHistory;

    public override bool Equals(object obj)
    {
      return obj is UIPersonalization && this.CompareArrays((Array) this._ESigHistoryDetails, (Array) ((UIPersonalization) obj)._ESigHistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((UIPersonalization) obj)._ExportImportKey) && object.Equals((object) this._Content, (object) ((UIPersonalization) obj)._Content)) && (object.Equals((object) this._WorkspaceId, (object) ((UIPersonalization) obj)._WorkspaceId) && object.Equals((object) this._Owner, (object) ((UIPersonalization) obj)._Owner) && (object.Equals((object) this._IsFrozen, (object) ((UIPersonalization) obj)._IsFrozen) && object.Equals((object) this._ChangeHistory, (object) ((UIPersonalization) obj)._ChangeHistory))) && base.Equals(obj);
    }

    public SubentityRef[] ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Content));
      }
    }

    public Primitive<int> WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (WorkspaceId));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
      }
    }
  }
}
