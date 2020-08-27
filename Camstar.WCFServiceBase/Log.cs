// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.Log
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web.Configuration;
using System.Xml;

namespace Camstar.WCF.Service
{
  internal class Log
  {
    private Stopwatch _Stopwatch = new Stopwatch();
    private UserProfile _UserProfile;
    private string _UserName;
    private string _ServiceName;
    private bool _RequestTrace;
    private string _RequestName;

    public Log(string serviceName, UserProfile userProfile)
    {
      this._UserProfile = userProfile;
      this._UserName = string.IsNullOrEmpty(this._UserProfile.Name) ? "Anonym" : this._UserProfile.Name;
      this._ServiceName = serviceName;
      if (userProfile.DebugRequest == null)
        return;
      this._RequestTrace = userProfile.DebugRequest.IncludeRRXML;
    }

    public void WriteXml(string methodName, string xml, bool isRequest, ResultStatus result)
    {
      bool result1;
      bool.TryParse(WebConfigurationManager.AppSettings["LogXmlDocument"], out result1);
      bool result2;
      bool.TryParse(WebConfigurationManager.AppSettings["LogStatistics"], out result2);
      if (!string.IsNullOrEmpty(this._RequestName) & result2)
        this._Stopwatch.Stop();
      if (!result1 && !this._RequestTrace || !this.FilterService())
        return;
      string appSetting1 = WebConfigurationManager.AppSettings["LogPath"];
      string str1 = string.Empty;
      string appSetting2 = WebConfigurationManager.AppSettings["LogNaming"];
      if (!string.IsNullOrEmpty(appSetting2))
      {
        string str2 = appSetting2;
        char[] chArray = new char[1]{ ';' };
        foreach (string str3 in str2.Split(chArray))
        {
          if (!(str3 == "service"))
          {
            if (!(str3 == "method"))
            {
              if (!(str3 == "time"))
              {
                if (!(str3 == "longtime"))
                {
                  if (str3 == "user")
                    str1 = str1 + this._UserName + "_";
                }
                else
                  str1 = str1 + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + "_";
              }
              else
                str1 = str1 + DateTime.Now.ToString("HHmmssfff") + "_";
            }
            else
              str1 = str1 + methodName + "_";
          }
          else
            str1 = str1 + this._ServiceName + "_";
        }
      }
      if (!Directory.Exists(appSetting1))
        return;
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(xml);
      if (xmlDocument.FirstChild is XmlDeclaration firstChild)
        firstChild.Encoding = Encoding.UTF8.WebName;
      this.MaskEncryptedFields(xmlDocument.ChildNodes);
      for (int index = 0; index < 100; ++index)
      {
        string str2 = appSetting1 + "\\" + str1 + (isRequest ? "XmlRequest" : "XmlResponse") + (index == 0 ? "" : "_" + index.ToString()) + ".xml";
        if (!File.Exists(str2))
        {
          try
          {
            if (result1)
              xmlDocument.Save(str2);
            if (this._UserProfile.DebugRequest != null && this._UserProfile.DebugRequest.IncludeRRXML && result != null)
            {
              if (result.DebugResponse == null)
                result.DebugResponse = new DebugResponse();
              XmlElement xmlElement = xmlDocument["__InSite"];
              if (xmlElement["__service"] != null)
                xmlElement = xmlElement["__service"];
              else if (xmlElement["__query"] != null)
                xmlElement = xmlElement["__query"];
              else if (xmlElement["__requestData"] != null)
                xmlElement = xmlElement["__requestData"];
              else if (xmlElement["__responseData"] != null)
                xmlElement = xmlElement["__responseData"];
              if (isRequest)
                result.DebugResponse.Request = this.FormatXml(xmlElement.OuterXml);
              else
                result.DebugResponse.Response = this.FormatXml(xmlElement.OuterXml);
            }
            if (!result2)
              break;
            if (string.IsNullOrEmpty(this._RequestName))
            {
              this._Stopwatch.Start();
              this._RequestName = str2.Substring(appSetting1.Length + 1);
              break;
            }
            if (!result2)
              break;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("{0}:{1},\t{2},\t{3},\t{4}", (object) this._ServiceName, (object) methodName, (object) this._Stopwatch.Elapsed.ToString(), (object) this._RequestName, (object) str2.Substring(appSetting1.Length + 1)));
            File.AppendAllText(appSetting1 + "\\Statistics.csv", stringBuilder.ToString());
            break;
          }
          catch
          {
          }
        }
      }
    }

    private string FormatXml(string sUnformattedXml)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(sUnformattedXml);
      StringBuilder sb = new StringBuilder();
      StringWriter stringWriter = new StringWriter(sb);
      XmlTextWriter xmlTextWriter = (XmlTextWriter) null;
      try
      {
        xmlTextWriter = new XmlTextWriter((TextWriter) stringWriter);
        xmlTextWriter.Formatting = Formatting.Indented;
        xmlDocument.WriteTo((XmlWriter) xmlTextWriter);
      }
      finally
      {
        xmlTextWriter?.Close();
      }
      return sb.ToString();
    }

    private void MaskEncryptedFields(XmlNodeList list)
    {
      bool flag = false;
      foreach (XmlNode xmlNode in list)
      {
        if (flag && xmlNode.Name == "__value")
        {
          xmlNode.InnerText = "******";
          flag = false;
        }
        else if (xmlNode.Name == "__name" && xmlNode.HasChildNodes)
        {
          string str = xmlNode.ChildNodes[0].Value == null ? string.Empty : xmlNode.ChildNodes[0].Value.ToLower();
          if (!string.IsNullOrEmpty(str) && str == "password" || str.EndsWith("password"))
            flag = true;
        }
        else
          flag = false;
        if (xmlNode.Attributes != null)
        {
          foreach (XmlNode attribute in (XmlNamedNodeMap) xmlNode.Attributes)
          {
            if (attribute.Name == "__encrypted")
              xmlNode.InnerText = "******";
          }
        }
        if (xmlNode.HasChildNodes)
          this.MaskEncryptedFields(xmlNode.ChildNodes);
      }
    }

    private bool FilterService()
    {
      bool flag = false;
      string appSetting1 = WebConfigurationManager.AppSettings["IncludedServices"];
      string appSetting2 = WebConfigurationManager.AppSettings["ExcludedServices"];
      if (!string.IsNullOrEmpty(appSetting1))
      {
        string str1 = appSetting1;
        char[] chArray = new char[1]{ ';' };
        foreach (string str2 in str1.Split(chArray))
        {
          if (str2 == this._ServiceName)
            flag = true;
        }
      }
      else
        flag = true;
      if (!string.IsNullOrEmpty(appSetting2))
      {
        string str1 = appSetting2;
        char[] chArray = new char[1]{ ';' };
        foreach (string str2 in str1.Split(chArray))
        {
          if (str2 == this._ServiceName)
            flag = false;
        }
      }
      return flag;
    }
  }
}
