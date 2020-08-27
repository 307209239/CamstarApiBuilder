// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleSizeDetailsChanges_Info
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
  public class SampleSizeDetailsChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Info_SampleSizeCode")]
    protected Info _SampleSizeCode;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Info_Accepts")]
    protected Info _Accepts;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Info_SampleSize")]
    protected Info _SampleSize;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Info_Rejects")]
    protected Info _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

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

    public Info SampleSizeCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleSizeCode));
      }
    }

    public Info Accepts
    {
      [param: In] set
      {
        this.PropertySet(nameof (Accepts), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Accepts));
      }
    }

    public Info SampleSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSize), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleSize));
      }
    }

    public Info Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rejects));
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
  }
}
