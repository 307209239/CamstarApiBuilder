// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkspaceDetail
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
  public class WorkspaceDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_IsActive")]
    protected Primitive<bool> _IsActive;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Prefix")]
    protected Primitive<string> _Prefix;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Color")]
    protected Primitive<string> _Color;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_SupportedBy")]
    protected Primitive<string> _SupportedBy;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_WorkspaceId")]
    protected Primitive<int> _WorkspaceId;
    [DataMember(EmitDefaultValue = false, Name = "WorkspaceDetail_Code")]
    protected Primitive<string> _Code;

    public override bool Equals(object obj)
    {
      return obj is WorkspaceDetail && object.Equals((object) this._Description, (object) ((WorkspaceDetail) obj)._Description) && (object.Equals((object) this._IsActive, (object) ((WorkspaceDetail) obj)._IsActive) && object.Equals((object) this._Prefix, (object) ((WorkspaceDetail) obj)._Prefix)) && (object.Equals((object) this._Color, (object) ((WorkspaceDetail) obj)._Color) && object.Equals((object) this._SupportedBy, (object) ((WorkspaceDetail) obj)._SupportedBy) && (object.Equals((object) this._WorkspaceId, (object) ((WorkspaceDetail) obj)._WorkspaceId) && object.Equals((object) this._Code, (object) ((WorkspaceDetail) obj)._Code))) && base.Equals(obj);
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<bool> IsActive
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsActive), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsActive));
      }
    }

    public Primitive<string> Prefix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prefix), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Prefix));
      }
    }

    public Primitive<string> Color
    {
      [param: In] set
      {
        this.PropertySet(nameof (Color), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Color));
      }
    }

    public Primitive<string> SupportedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SupportedBy), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SupportedBy));
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

    public Primitive<string> Code
    {
      [param: In] set
      {
        this.PropertySet(nameof (Code), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Code));
      }
    }
  }
}
