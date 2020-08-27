// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WCFObjectBase
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public abstract class WCFObjectBase : ICreator, INotifyPropertyChanged
  {
    protected const string ExceptionFormat = "Invalid path for '({0}).{1}' expression. {2}";
    protected const string TypeErrorMessage = "Type '{0}' doesn`t exist.";
    protected const string FieldErrorMessage = "Field path is broken at '.{0}'.";

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string propName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propName));
    }

    protected static FieldInfo GetField(Type type, string name)
    {
      FieldInfo field = type.GetField("_" + name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
      if ((object) field == null)
        field = type.GetField("_" + name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic);
      FieldInfo fieldInfo = field;
      if (fieldInfo == (FieldInfo) null)
        throw new WCFServiceException(string.Format("Field path is broken at '.{0}'.", (object) name));
      return fieldInfo;
    }

    private void SetCreateAttribute(WCFObjectBase parent, string fieldName)
    {
      Type type = parent.GetType();
      FieldInfo field = WCFObjectBase.GetField(type, fieldName);
      if (!(field != (FieldInfo) null) || !(field.GetValue((object) parent) is CDOObject cdoObject))
        return;
      MetadataAttribute customAttribute = WCFObjectBase.GetField(type.Assembly.GetType(type.Namespace + "." + type.Name + "_Environment"), fieldName).GetCustomAttributes(typeof (MetadataAttribute), false)[0] as MetadataAttribute;
      if (customAttribute.CreateOnInitialize || customAttribute.FieldTypeCode != FieldTypeCode.Object || customAttribute.IsReadOnly)
        return;
      cdoObject.FieldAction = new Action?(Action.Create);
    }

    private void SetFieldValue(string fieldPath, object value, bool replace)
    {
      Type type1 = this.GetType();
      int length = fieldPath.IndexOf('.');
      if (length == -1)
      {
        string name = fieldPath.Split(':')[0];
        FieldInfo field = WCFObjectBase.GetField(type1, name);
        if (((field.GetValue((object) this) != null ? 0 : (value != null ? 1 : 0)) | (replace ? 1 : 0)) == 0)
          return;
        if (field.FieldType.GetInterface(typeof (IPrimitive).Name, true) != (Type) null)
        {
          object obj = Activator.CreateInstance(field.FieldType.Assembly.FullName, field.FieldType.FullName).Unwrap();
          Type type2 = ((IEnumerable<Type>) field.FieldType.GetGenericArguments()).FirstOrDefault<Type>();
          if (type2 != (Type) null && value is string)
            value = !type2.IsEnum ? Convert.ChangeType(value, type2, (IFormatProvider) null) : Enum.Parse(type2, value as string, true);
          (obj as IPrimitive).SetValue(value);
          value = obj;
        }
        field.SetValue((object) this, value);
      }
      else
      {
        string[] strArray = fieldPath.Substring(0, length).Split(':');
        string str1 = strArray[0];
        FieldInfo field = WCFObjectBase.GetField(type1, str1);
        string str2 = field.FieldType.Name;
        Type type2 = field.FieldType.GetElementType();
        if (strArray.Length > 1)
        {
          string str3 = string.Empty;
          if (field.FieldType.IsSubclassOf(typeof (Info)))
            str3 = "_Info";
          if (field.FieldType.IsSubclassOf(typeof (Environment)))
            str3 = "_Environment";
          str2 = strArray[1] + str3;
          Type type3 = field.FieldType.Assembly.GetType(field.FieldType.Namespace + "." + str2);
          if (type3 == (Type) null)
            throw new WCFServiceException(string.Format("Type '{0}' doesn`t exist.", (object) str2));
          type2 = type3;
        }
        object obj1 = field.GetValue((object) this);
        if (field.FieldType.IsArray)
        {
          if (obj1 == null || (obj1 as Array).Length == 0)
            obj1 = (object) Array.CreateInstance(field.FieldType.GetElementType(), 1);
          object obj2 = (obj1 as Array).GetValue(0) ?? Activator.CreateInstance(field.FieldType.Assembly.FullName, type2.FullName).Unwrap();
          (obj2 as WCFObjectBase).SetFieldValue(fieldPath.Substring(length + 1), value, replace);
          (obj1 as Array).SetValue(obj2, 0);
        }
        else
        {
          if (obj1 == null)
            obj1 = Activator.CreateInstance(field.FieldType.Assembly.FullName, field.FieldType.Namespace + "." + str2).Unwrap();
          (obj1 as WCFObjectBase).SetFieldValue(fieldPath.Substring(length + 1), value, replace);
        }
        field.SetValue((object) this, obj1);
        this.SetCreateAttribute(this, str1);
      }
    }

    private object GetFieldValue(string fieldPath)
    {
      Type type = this.GetType();
      int length = fieldPath.IndexOf('.');
      object obj;
      if (length == -1)
      {
        string name = fieldPath.Split(':')[0];
        FieldInfo field = WCFObjectBase.GetField(type, name);
        obj = field.GetValue((object) this);
        if (obj != null && field.FieldType.GetInterface(typeof (IPrimitive).Name, false) != (Type) null)
          obj = (obj as IPrimitive).GetValue();
      }
      else
      {
        string name = fieldPath.Substring(0, length).Split(':')[0];
        FieldInfo field = WCFObjectBase.GetField(type, name);
        obj = field.GetValue((object) this);
        if (field.FieldType.IsArray)
        {
          obj = obj == null || (obj as Array).Length == 0 ? (object) null : (obj as Array).GetValue(0);
          if (obj != null)
            obj = (obj as WCFObjectBase).GetFieldValue(fieldPath.Substring(length + 1));
        }
        else if (obj != null)
          obj = (obj as WCFObjectBase).GetFieldValue(fieldPath.Substring(length + 1));
      }
      return obj;
    }

    void ICreator.SetValue(string fieldPath, object value)
    {
      try
      {
        this.SetFieldValue(fieldPath, value, false);
      }
      catch (WCFServiceException ex)
      {
        throw new WCFServiceException(string.Format("Invalid path for '({0}).{1}' expression. {2}", (object) this.GetType().Name, (object) fieldPath, (object) ex.Message));
      }
    }

    void ICreator.ReplaceValue(string fieldPath, object value)
    {
      try
      {
        this.SetFieldValue(fieldPath, value, true);
      }
      catch (WCFServiceException ex)
      {
        throw new WCFServiceException(string.Format("Invalid path for '({0}).{1}' expression. {2}", (object) this.GetType().Name, (object) fieldPath, (object) ex.Message));
      }
    }

    object ICreator.GetValue(string fieldPath)
    {
      try
      {
        return this.GetFieldValue(fieldPath);
      }
      catch (WCFServiceException ex)
      {
        throw new WCFServiceException(string.Format("Invalid path for '({0}).{1}' expression. {2}", (object) this.GetType().Name, (object) fieldPath, (object) ex.Message));
      }
    }

    public virtual bool IsEmpty
    {
      get
      {
        return this.IsEmptyObject();
      }
    }

    protected bool CompareArrays(Array objA, Array objB)
    {
      bool flag = object.Equals((object) objA, (object) objB);
      if (objA != null && objB != null && objA.Length == objB.Length)
      {
        for (int index = 0; index < objA.Length; ++index)
        {
          flag = object.Equals(objA.GetValue(index), objB.GetValue(index));
          if (!flag)
            break;
        }
      }
      return flag;
    }

    protected bool IsEmptyObject()
    {
      bool flag = true;
      foreach (FieldInfo field in this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
      {
        object obj1 = field.GetValue((object) this);
        if (obj1 is WCFObjectBase)
          flag &= ((WCFObjectBase) obj1).IsEmpty;
        if (obj1 is Array)
        {
          foreach (object obj2 in (IEnumerable) obj1)
          {
            if (obj2 is WCFObjectBase)
              flag &= ((WCFObjectBase) obj2).IsEmpty;
          }
        }
      }
      return flag;
    }

    public WCFObjectBase Clone()
    {
      DataContractSerializer contractSerializer = new DataContractSerializer(this.GetType());
      Stream stream = (Stream) new MemoryStream();
      contractSerializer.WriteObject(stream, (object) this);
      stream.Seek(0L, SeekOrigin.Begin);
      WCFObjectBase wcfObjectBase = (WCFObjectBase) contractSerializer.ReadObject(stream);
      stream.Close();
      return wcfObjectBase;
    }

    protected object PropertyGet(string name)
    {
      return WCFObjectBase.GetField(this.GetType(), name).GetValue((object) this);
    }

    protected void PropertySet(string name, object value)
    {
      FieldInfo field = WCFObjectBase.GetField(this.GetType(), name);
      if (field.GetValue((object) this) == value)
        return;
      field.SetValue((object) this, value);
      this.NotifyPropertyChanged(name);
      if (!(value is CDOObject cdoObject))
        return;
      cdoObject.PropertyChanged += (PropertyChangedEventHandler) ((sender, e) => this.NotifyPropertyChanged(e.PropertyName));
    }
  }
}
