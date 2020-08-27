// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.InSiteXmlParser
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Xml;

namespace Camstar.WCF.Service
{
  internal class InSiteXmlParser
  {
    private InSiteXmlWriter _InSiteXmlWriter;
    private InSiteXmlReader _InSiteXmlReader;
    private string _ServiceName;
    private UserProfile _UserProfile;

    public InSiteXmlParser(string serviceName, UserProfile userProfile)
    {
      this._UserProfile = userProfile;
      this._ServiceName = serviceName;
    }

    public string GetXmlAsString()
    {
      return this._InSiteXmlWriter.XmlToString().Replace("</__inputData><__execute /><__inputData>", "</__inputData><__inputData>");
    }

    public void ToObjectsAsMethodCall(string outXml, Result result, ResultStatus resultStatus)
    {
      this._InSiteXmlReader = new InSiteXmlReader(outXml);
      this.FillResponseData(new UnknownObjectWriter((object) result), resultStatus);
    }

    public void SetService()
    {
      this._InSiteXmlWriter = new InSiteXmlWriter(this._UserProfile);
      this._InSiteXmlWriter.BeginElement("__service", new string[1]
      {
        "__serviceType"
      }, new object[1]{ (object) this._ServiceName });
      this._InSiteXmlWriter.BeginElement("__utcOffset", new UnknownObjectReader((object) this._UserProfile.UTCOffset.ToString()));
      this._InSiteXmlWriter.EndElement();
      bool result;
      bool.TryParse(WebConfigurationManager.AppSettings["ProcessTxnGUID"], out result);
      if (!result)
        return;
      this._InSiteXmlWriter.BeginElement("__txnGUID", new UnknownObjectReader((object) Guid.NewGuid().ToString()));
      this._InSiteXmlWriter.EndElement();
    }

    public void ToXmlAsMethodCall(string name, DCObject cdo, Parameters parameters)
    {
      if (cdo != null)
      {
        this._InSiteXmlWriter.BeginElement("__inputData");
        this.FillInputData(new UnknownObjectReader((object) cdo));
        this._InSiteXmlWriter.EndElement();
      }
      if (name != "ExecuteTransaction")
      {
        if (!(name != "GetEnvironment") || !(name != "AddDataTransaction"))
          return;
        this._InSiteXmlWriter.BeginElement("__perform");
        this._InSiteXmlWriter.BeginElement("__eventName", new UnknownObjectReader((object) name));
        this._InSiteXmlWriter.EndElement();
        if (parameters != null)
        {
          this._InSiteXmlWriter.BeginElement("__parameters");
          foreach (UnknownObjectReader field in new UnknownObjectReader((object) parameters).Fields)
          {
            this._InSiteXmlWriter.BeginElement("__parameter");
            this._InSiteXmlWriter.BeginElement("__name", new UnknownObjectReader((object) field.Name));
            this._InSiteXmlWriter.EndElement();
            this._InSiteXmlWriter.BeginElement("__value", new UnknownObjectReader(field.Value));
            this._InSiteXmlWriter.EndElement();
            this._InSiteXmlWriter.EndElement();
          }
          this._InSiteXmlWriter.EndElement();
        }
        this._InSiteXmlWriter.EndElement();
      }
      else
      {
        this._InSiteXmlWriter.BeginElement("__execute");
        this._InSiteXmlWriter.EndElement();
      }
    }

    public void SetRequest(Request request)
    {
      this._InSiteXmlWriter.BeginElement("__requestData");
      this._InSiteXmlWriter.BeginElement("CompletionMsg");
      this._InSiteXmlWriter.EndElement();
      if (request != null)
      {
        UnknownObjectReader info = new UnknownObjectReader((object) request)["Info"];
        if (info != null)
          this.FillRequestData(info);
      }
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.EndElement();
      if (this._UserProfile.DebugRequest != null)
      {
        this._InSiteXmlWriter.BeginElement("__debugRequest");
        InSiteXmlWriter inSiteXmlWriter1 = this._InSiteXmlWriter;
        bool flag = this._UserProfile.DebugRequest.DisableCommit;
        UnknownObjectReader unknownObjectReader1 = new UnknownObjectReader((object) flag.ToString().ToLower());
        inSiteXmlWriter1.BeginElement("__disableCommit", unknownObjectReader1);
        this._InSiteXmlWriter.EndElement();
        InSiteXmlWriter inSiteXmlWriter2 = this._InSiteXmlWriter;
        flag = this._UserProfile.DebugRequest.TraceToResponseXML;
        UnknownObjectReader unknownObjectReader2 = new UnknownObjectReader((object) flag.ToString().ToLower());
        inSiteXmlWriter2.BeginElement("__traceToResponseXML", unknownObjectReader2);
        this._InSiteXmlWriter.EndElement();
        InSiteXmlWriter inSiteXmlWriter3 = this._InSiteXmlWriter;
        flag = this._UserProfile.DebugRequest.IncludeTimestamps;
        UnknownObjectReader unknownObjectReader3 = new UnknownObjectReader((object) flag.ToString().ToLower());
        inSiteXmlWriter3.BeginElement("__includeTimestamps", unknownObjectReader3);
        this._InSiteXmlWriter.EndElement();
        this._InSiteXmlWriter.EndElement();
      }
      this._InSiteXmlWriter.Close();
    }

    public void DirectRequest(string xml)
    {
      this._InSiteXmlWriter = new InSiteXmlWriter(this._UserProfile);
      this._InSiteXmlWriter.Write(xml);
      if (this._UserProfile.DebugRequest != null)
      {
        this._InSiteXmlWriter.BeginElement("__debugRequest");
        InSiteXmlWriter inSiteXmlWriter1 = this._InSiteXmlWriter;
        bool flag = this._UserProfile.DebugRequest.DisableCommit;
        UnknownObjectReader unknownObjectReader1 = new UnknownObjectReader((object) flag.ToString().ToLower());
        inSiteXmlWriter1.BeginElement("__disableCommit", unknownObjectReader1);
        this._InSiteXmlWriter.EndElement();
        InSiteXmlWriter inSiteXmlWriter2 = this._InSiteXmlWriter;
        flag = this._UserProfile.DebugRequest.TraceToResponseXML;
        UnknownObjectReader unknownObjectReader2 = new UnknownObjectReader((object) flag.ToString().ToLower());
        inSiteXmlWriter2.BeginElement("__traceToResponseXML", unknownObjectReader2);
        this._InSiteXmlWriter.EndElement();
        InSiteXmlWriter inSiteXmlWriter3 = this._InSiteXmlWriter;
        flag = this._UserProfile.DebugRequest.IncludeTimestamps;
        UnknownObjectReader unknownObjectReader3 = new UnknownObjectReader((object) flag.ToString().ToLower());
        inSiteXmlWriter3.BeginElement("__includeTimestamps", unknownObjectReader3);
        this._InSiteXmlWriter.EndElement();
        this._InSiteXmlWriter.EndElement();
      }
      this._InSiteXmlWriter.Close();
    }

    public void ToXmlAsQuery(
      string name,
      QueryParameters parameters,
      QueryOptions options,
      bool needStart = true,
      bool needClose = true)
    {
      if (needStart)
        this._InSiteXmlWriter = new InSiteXmlWriter(this._UserProfile);
      this._InSiteXmlWriter.BeginElement("__query");
      if (options != null && options.QueryType.HasValue)
      {
        if (options.ChangeCount.HasValue)
          this._InSiteXmlWriter.BeginElement("__queryName", new UnknownObjectReader((object) name), new string[2]
          {
            "__type",
            "__changeCount"
          }, new object[2]
          {
            (object) options.QueryType.ToString().ToLower(),
            (object) options.ChangeCount
          });
        else
          this._InSiteXmlWriter.BeginElement("__queryName", new UnknownObjectReader((object) name), new string[1]
          {
            "__type"
          }, new object[1]
          {
            (object) options.QueryType.ToString().ToLower()
          });
      }
      else
        this._InSiteXmlWriter.BeginElement("__queryName", new UnknownObjectReader((object) name));
      this._InSiteXmlWriter.EndElement();
      if (parameters != null && parameters.Parameters != null)
      {
        this._InSiteXmlWriter.BeginElement("__queryParameters");
        foreach (QueryParameter parameter in parameters.Parameters)
        {
          this._InSiteXmlWriter.BeginElement("__parameter");
          this._InSiteXmlWriter.BeginElement("__name", new UnknownObjectReader((object) parameter.Name));
          this._InSiteXmlWriter.EndElement();
          this._InSiteXmlWriter.BeginElement("__value", new UnknownObjectReader((object) parameter.Value));
          this._InSiteXmlWriter.EndElement();
          this._InSiteXmlWriter.EndElement();
        }
        this._InSiteXmlWriter.EndElement();
      }
      this._InSiteXmlWriter.WriteOptions(options);
      this._InSiteXmlWriter.BeginElement("__utcOffset", new UnknownObjectReader((object) this._UserProfile.UTCOffset.ToString()));
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.EndElement();
      if (!needClose)
        return;
      this._InSiteXmlWriter.Close();
    }

    public void ToXmlAsXmlQuery(string xmlQueryText, QueryOptions options)
    {
      this._InSiteXmlWriter = new InSiteXmlWriter(this._UserProfile);
      this._InSiteXmlWriter.BeginElement("__query");
      this._InSiteXmlWriter.BeginElement("__xmlQuery", new UnknownObjectReader((object) xmlQueryText));
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.WriteOptions(options);
      this._InSiteXmlWriter.BeginElement("__utcOffset", new UnknownObjectReader((object) this._UserProfile.UTCOffset.ToString()));
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.Close();
    }

    public void ToXmlAsQueryAdHoc(string text, QueryOptions options)
    {
      this._InSiteXmlWriter = new InSiteXmlWriter(this._UserProfile);
      this._InSiteXmlWriter.BeginElement("__query");
      this._InSiteXmlWriter.BeginElement("__queryText", new UnknownObjectReader((object) text));
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.WriteOptions(options);
      this._InSiteXmlWriter.BeginElement("__utcOffset", new UnknownObjectReader((object) this._UserProfile.UTCOffset.ToString()));
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.Close();
    }

    public void ToObjectsAsQuery(string outXml, RecordSet recordSet, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._InSiteXmlReader = new InSiteXmlReader(outXml);
      InSiteXmlReader inSiteXmlReader1 = this._InSiteXmlReader["__InSite"];
      InSiteXmlReader inSiteXmlReader2 = inSiteXmlReader1["__responseData"] ?? inSiteXmlReader1["__query"]["__responseData"];
      InSiteXmlReader exceptionData = inSiteXmlReader2["__exceptionData"];
      if (exceptionData != null)
      {
        this.FillExceptionData(resultStatus, exceptionData);
      }
      else
      {
        if (!this.FillRecordSet(inSiteXmlReader2, recordSet))
          return;
        recordSet.Headers = (Header[]) null;
      }
    }

    public void ToDirectResult(string outXml, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._InSiteXmlReader = new InSiteXmlReader(outXml);
      InSiteXmlReader inSiteXmlReader1 = this._InSiteXmlReader["__InSite"];
      InSiteXmlReader inSiteXmlReader2 = inSiteXmlReader1["__responseData"];
      InSiteXmlReader inSiteXmlReader3 = inSiteXmlReader1["__debugResponse"];
      if (inSiteXmlReader2 == null && inSiteXmlReader1["__service"] != null)
      {
        inSiteXmlReader2 = inSiteXmlReader1["__service"]["__responseData"];
        inSiteXmlReader3 = inSiteXmlReader1["__service"]["__debugResponse"];
      }
      if (inSiteXmlReader2 != null)
      {
        InSiteXmlReader exceptionData = inSiteXmlReader2["__exceptionData"];
        if (exceptionData != null)
          this.FillExceptionData(resultStatus, exceptionData);
        else
          resultStatus.Message = inSiteXmlReader2["CompletionMsg"].Value;
      }
      if (inSiteXmlReader3 == null)
        return;
      ServerTraceItem root = new ServerTraceItem()
      {
        Name = "Root"
      };
      this.FillDebugData(inSiteXmlReader3.Fields[0], root);
      if (resultStatus.DebugResponse == null)
        resultStatus.DebugResponse = new DebugResponse();
      resultStatus.DebugResponse.Trace = root;
      resultStatus.DebugResponse.Fault = !resultStatus.IsSuccess;
    }

    public void ToObjectsAsQueries(string outXml, RecordSet[] recordSet, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._InSiteXmlReader = new InSiteXmlReader(outXml);
      InSiteXmlReader inSiteXmlReader1 = this._InSiteXmlReader["__InSite"];
      InSiteXmlReader inSiteXmlReader2 = inSiteXmlReader1["__responseData"];
      if (inSiteXmlReader2 == null)
      {
        InSiteXmlReader[] fields = inSiteXmlReader1.GetFields("__query");
        if (fields == null || fields.Length == 0)
          return;
        for (int index = 0; index < fields.Length; ++index)
        {
          InSiteXmlReader inSiteXmlReader3 = fields[index]["__responseData"];
          if (inSiteXmlReader3 != null)
          {
            recordSet[index] = new RecordSet();
            if (this.FillRecordSet(inSiteXmlReader3, recordSet[index]))
              recordSet[index].Headers = (Header[]) null;
          }
        }
      }
      else
      {
        InSiteXmlReader exceptionData = inSiteXmlReader2["__exceptionData"];
        if (exceptionData == null)
          return;
        this.FillExceptionData(resultStatus, exceptionData);
      }
    }

    public void ToXmlLogin()
    {
      this._InSiteXmlWriter = new InSiteXmlWriter(this._UserProfile);
      this._InSiteXmlWriter.BeginElement("__requestData");
      this._InSiteXmlWriter.BeginElement("__sessionValues");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__sessionInfo");
      this._InSiteXmlWriter.BeginElement("__userName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userFullName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userDomain");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userMenuName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userWebMenuName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userPortalMenuName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userPortalMobileMenuName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userPrimaryOrganizationName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__userPortalProfile");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__language");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__languageName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__terminology");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.BeginElement("__terminologyName");
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.Close();
    }

    public void ToSessionObject(string outXml, SessionData sessionData, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._InSiteXmlReader = new InSiteXmlReader(outXml);
      InSiteXmlReader inSiteXmlReader1 = this._InSiteXmlReader["__InSite"]["__responseData"];
      InSiteXmlReader exceptionData = inSiteXmlReader1["__exceptionData"];
      if (exceptionData != null)
      {
        this.FillExceptionData(resultStatus, exceptionData);
      }
      else
      {
        InSiteXmlReader inSiteXmlReader2 = inSiteXmlReader1["__sessionValues"];
        if (inSiteXmlReader2["Factory"] != null && inSiteXmlReader2["Factory"]["__name"] != null)
          sessionData.Factory = inSiteXmlReader2["Factory"]["__name"].Value;
        if (inSiteXmlReader2["Operation"] != null && inSiteXmlReader2["Operation"]["__name"] != null)
          sessionData.Operation = inSiteXmlReader2["Operation"]["__name"].Value;
        if (inSiteXmlReader2["WorkCenter"] != null && inSiteXmlReader2["WorkCenter"]["__name"] != null)
          sessionData.WorkCenter = inSiteXmlReader2["WorkCenter"]["__name"].Value;
        if (inSiteXmlReader2["Login"] != null && inSiteXmlReader2["Login"]["__Id"] != null)
          sessionData.UserID = inSiteXmlReader2["Login"]["__Id"].Value;
        if (inSiteXmlReader2["Login"] != null && inSiteXmlReader2["Login"]["__name"] != null)
          sessionData.UserName = inSiteXmlReader2["Login"]["__name"].Value;
        sessionData.ShowLineAssignmentOnLogon = true;
        sessionData.FilterTags = sessionData.FilterTags ?? this._UserProfile.FilterTags;
        sessionData.FilterTagAccess = sessionData.FilterTagAccess ?? this._UserProfile.FilterTagAccess;
        InSiteXmlReader inSiteXmlReader3 = inSiteXmlReader2["LocalSettings"];
        if (inSiteXmlReader3 != null)
        {
          if (inSiteXmlReader3["DateFormat"] != null)
            sessionData.DateFormat = inSiteXmlReader3["DateFormat"].Value;
          if (inSiteXmlReader3["TimeFormat"] != null)
            sessionData.TimeFormat = inSiteXmlReader3["TimeFormat"].Value;
          if (inSiteXmlReader3["DecimalSeparator"] != null)
            sessionData.DecimalSeparator = inSiteXmlReader3["DecimalSeparator"].Value;
          if (inSiteXmlReader3["GroupSeparator"] != null)
            sessionData.GroupSeparator = inSiteXmlReader3["GroupSeparator"].Value;
        }
        bool result;
        if (inSiteXmlReader2["UserProfile"] != null && inSiteXmlReader2["UserProfile"]["ShowLineAssignmentOnLogon"] != null && bool.TryParse(inSiteXmlReader2["UserProfile"]["ShowLineAssignmentOnLogon"].Value, out result))
          sessionData.ShowLineAssignmentOnLogon = result;
        InSiteXmlReader inSiteXmlReader4 = inSiteXmlReader1["__sessionInfo"];
        if (inSiteXmlReader4["__userFullName"] != null)
          sessionData.UserFullName = inSiteXmlReader4["__userFullName"].Value;
        if (inSiteXmlReader4["__userDomain"] != null)
          sessionData.UserDomain = inSiteXmlReader4["__userDomain"].Value;
        if (inSiteXmlReader4["__userMenuName"] != null)
          sessionData.UserMenuName = inSiteXmlReader4["__userMenuName"].Value;
        if (inSiteXmlReader4["__userWebMenuName"] != null)
          sessionData.UserWebMenuName = inSiteXmlReader4["__userWebMenuName"].Value;
        if (inSiteXmlReader4["__userPortalMenuName"] != null)
          sessionData.UserPortalMenuName = inSiteXmlReader4["__userPortalMenuName"].Value;
        if (inSiteXmlReader4["__userPortalMobileMenuName"] != null)
          sessionData.UserPortalMobileMenuName = inSiteXmlReader4["__userPortalMobileMenuName"].Value;
        if (inSiteXmlReader4["__userPrimaryOrganizationName"] != null)
          sessionData.UserPrimaryOrganizationName = inSiteXmlReader4["__userPrimaryOrganizationName"].Value;
        if (inSiteXmlReader4["__userPortalProfile"] != null)
        {
          sessionData.UserPortalProfile = new UserProfileData();
          if (inSiteXmlReader4["__userPortalProfile"]["InstanceId"] != null)
            sessionData.UserPortalProfile.InstanceID = inSiteXmlReader4["__userPortalProfile"]["InstanceId"].Value;
          if (inSiteXmlReader4["__userPortalProfile"]["PortalHomePage"] != null)
            sessionData.UserPortalProfile.PortalHomePage = inSiteXmlReader4["__userPortalProfile"]["PortalHomePage"].Value;
          if (inSiteXmlReader4["__userPortalProfile"]["Theme"] != null)
            sessionData.UserPortalProfile.Theme = inSiteXmlReader4["__userPortalProfile"]["Theme"].Value;
          if (inSiteXmlReader4["__userPortalProfile"]["PortalMobileHomePage"] != null)
            sessionData.UserPortalProfile.PortalMobileHomePage = inSiteXmlReader4["__userPortalProfile"]["PortalMobileHomePage"].Value;
        }
        if (inSiteXmlReader4["__language"] != null)
          sessionData.Language = inSiteXmlReader4["__language"].Value;
        if (inSiteXmlReader4["__languageName"] != null)
          sessionData.LanguageName = inSiteXmlReader4["__languageName"].Value;
        if (inSiteXmlReader4["__terminology"] != null)
          sessionData.Terminology = inSiteXmlReader4["__terminology"].Value;
        if (inSiteXmlReader4["__terminologyName"] == null)
          return;
        sessionData.TerminologyName = inSiteXmlReader4["__terminologyName"].Value;
      }
    }

    public void ToXmlLabels(LabelRequest request)
    {
      this._InSiteXmlWriter = new InSiteXmlWriter(this._UserProfile);
      this._InSiteXmlWriter.BeginElement("__requestData");
      this._InSiteXmlWriter.BeginElement("__metadata");
      foreach (Label label in request.Labels)
      {
        if (label.LabelType.HasValue)
          this._InSiteXmlWriter.BeginElement("__label", new string[1]
          {
            "__type"
          }, new object[1]
          {
            (object) label.LabelType.ToString().ToLower()
          });
        else
          this._InSiteXmlWriter.BeginElement("__label");
        if (label.ID.HasValue)
        {
          this._InSiteXmlWriter.BeginElement("__Id", new UnknownObjectReader((object) label.ID));
          this._InSiteXmlWriter.EndElement();
        }
        else if (!string.IsNullOrEmpty(label.Name))
        {
          this._InSiteXmlWriter.BeginElement("__name", new UnknownObjectReader((object) label.Name));
          this._InSiteXmlWriter.EndElement();
        }
        this._InSiteXmlWriter.EndElement();
      }
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.EndElement();
      this._InSiteXmlWriter.Close();
    }

    public void ToLabelsObject(string outXml, LabelResult result, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      this._InSiteXmlReader = new InSiteXmlReader(outXml);
      InSiteXmlReader inSiteXmlReader1 = this._InSiteXmlReader["__InSite"]["__responseData"];
      InSiteXmlReader exceptionData = inSiteXmlReader1["__exceptionData"];
      if (exceptionData != null)
        this.FillExceptionData(resultStatus, exceptionData);
      InSiteXmlReader inSiteXmlReader2 = inSiteXmlReader1["__metadata"];
      if (inSiteXmlReader2 == null)
        return;
      List<Label> labelList = new List<Label>();
      foreach (InSiteXmlReader field in inSiteXmlReader2.Fields)
      {
        Label label = new Label();
        if (field.Name == "__label")
        {
          if (field["__Id"] != null)
            label.ID = new int?(int.Parse(field["__Id"].Value));
          if (field["__name"] != null)
            label.Name = field["__name"].Value;
          if (field["__defaultValue"] != null)
            label.DefaultValue = field["__defaultValue"].Value;
          if (field["__value"] != null)
            label.Value = field["__value"].Value;
          labelList.Add(label);
        }
      }
      result.Labels = new Label[labelList.Count];
      labelList.CopyTo(result.Labels);
    }

    private void FillExceptionData(ResultStatus resultStatus, InSiteXmlReader exceptionData)
    {
      resultStatus.IsSuccess = false;
      resultStatus.ExceptionData = new ExceptionDataType();
      resultStatus.ExceptionData.Code = int.Parse(exceptionData["__errorCode"].Value);
      resultStatus.ExceptionData.failureContext = exceptionData["__failureContext"].Value;
      resultStatus.ExceptionData.Description = exceptionData["__errorDescription"].Value;
      resultStatus.ExceptionData.Source = exceptionData["__errorSource"].Value;
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Server;
      int num = 0;
      if (exceptionData["__exceptionParameters"] == null)
        return;
      resultStatus.ExceptionData.ExceptionParameters = new ExceptionParameter[exceptionData["__exceptionParameters"].GetFields().Length];
      foreach (InSiteXmlReader field in exceptionData["__exceptionParameters"].GetFields())
        resultStatus.ExceptionData.ExceptionParameters.SetValue((object) new ExceptionParameter(field.Name, field.Value), num++);
    }

    private bool FillRecordSet(InSiteXmlReader inSiteXmlReader, RecordSet recordSet)
    {
      bool flag = true;
      int index1 = 0;
      int length = 0;
      InSiteXmlReader inSiteXmlReader1 = inSiteXmlReader["__recordCount"];
      if (inSiteXmlReader1 != null)
        recordSet.TotalCount = int.Parse(inSiteXmlReader1.Value);
      InSiteXmlReader inSiteXmlReader2 = inSiteXmlReader["__recordSetHeader"];
      if (inSiteXmlReader2 != null)
      {
        InSiteXmlReader[] list = inSiteXmlReader2.GetList();
        length = list.Length;
        if (length > 0)
          flag = false;
        recordSet.Headers = new Header[length];
        foreach (InSiteXmlReader inSiteXmlReader3 in list)
        {
          recordSet.Headers[index1] = new Header();
          recordSet.Headers[index1].Name = inSiteXmlReader3["__name"].Value;
          recordSet.Headers[index1].Label = new Label();
          InSiteXmlReader inSiteXmlReader4 = inSiteXmlReader3["__label"];
          recordSet.Headers[index1].Label.ID = new int?(int.Parse(inSiteXmlReader4["__Id"].Value));
          recordSet.Headers[index1].Label.Name = inSiteXmlReader4["__name"].Value;
          recordSet.Headers[index1].Label.Value = inSiteXmlReader4["__value"].Value;
          recordSet.Headers[index1].Label.DefaultValue = inSiteXmlReader4["__defaultValue"].Value;
          recordSet.Headers[index1].TypeCode = this.ToTypeCode(inSiteXmlReader3["__fieldType"]["__genericType"].Value);
          ++index1;
        }
      }
      InSiteXmlReader inSiteXmlReader5 = inSiteXmlReader["__recordSet"];
      if (inSiteXmlReader5 != null)
      {
        InSiteXmlReader[] list = inSiteXmlReader5.GetList();
        if (list.Length != 0)
        {
          recordSet.Rows = new Row[list.Length];
          int index2 = 0;
          foreach (InSiteXmlReader inSiteXmlReader3 in list)
          {
            if (length == 0)
            {
              length = inSiteXmlReader3.Fields.Length;
              recordSet.Headers = new Header[length];
              foreach (InSiteXmlReader field in inSiteXmlReader3.Fields)
              {
                recordSet.Headers[index2] = new Header();
                recordSet.Headers[index2].Name = field.Name;
                recordSet.Headers[index2].Label = new Label();
                recordSet.Headers[index2].Label.Name = field.Name;
                recordSet.Headers[index2].Label.Value = field.Name;
                recordSet.Headers[index2].Label.DefaultValue = field.Name;
                ++index2;
              }
              index2 = 0;
            }
            recordSet.Rows[index2] = new Row();
            recordSet.Rows[index2].Values = new string[length];
            int num = 0;
            foreach (Header header in recordSet.Headers)
              recordSet.Rows[index2].Values[num++] = inSiteXmlReader3[header.Name].Value;
            ++index2;
          }
        }
      }
      return flag;
    }

    private TypeCode ToTypeCode(string genericType)
    {
      TypeCode typeCode = TypeCode.String;
      if (!(genericType == "Integer"))
      {
        if (!(genericType == "Timestamp"))
        {
          if (!(genericType == "Float") && !(genericType == "Fixed"))
          {
            if (!(genericType == "Boolean"))
            {
              if (genericType == "Decimal")
                typeCode = TypeCode.Decimal;
            }
            else
              typeCode = TypeCode.Boolean;
          }
          else
            typeCode = TypeCode.Double;
        }
        else
          typeCode = TypeCode.DateTime;
      }
      else
        typeCode = TypeCode.Int32;
      return typeCode;
    }

    private bool FillRequestData(UnknownObjectReader info)
    {
      bool flag = false;
      foreach (UnknownObjectReader field in info.Fields)
      {
        if (field.Value is Info info1)
        {
          if (info1.RequestSelectionValues)
          {
            this._InSiteXmlWriter.BeginElement(field.Name);
            this._InSiteXmlWriter.BeginElement("__requestSelectionValuesEx");
            SelectionValuesInfo selectionValuesInfo = info1.RequestSelectionValuesInfo ?? new SelectionValuesInfo();
            if (selectionValuesInfo.Parameters == null)
              selectionValuesInfo.Parameters = new QueryParameter[2]
              {
                new QueryParameter("NameFilter", "%"),
                new QueryParameter("SpecificTypeOnly", "0")
              };
            this._InSiteXmlWriter.WriteOptions(selectionValuesInfo.Options);
            this._InSiteXmlWriter.BeginElement("__queryParameters");
            foreach (QueryParameter parameter in selectionValuesInfo.Parameters)
            {
              this._InSiteXmlWriter.BeginElement("__parameter");
              this._InSiteXmlWriter.BeginElement("__name", new UnknownObjectReader((object) parameter.Name));
              this._InSiteXmlWriter.EndElement();
              this._InSiteXmlWriter.BeginElement("__value", new UnknownObjectReader((object) parameter.Value));
              this._InSiteXmlWriter.EndElement();
              this._InSiteXmlWriter.EndElement();
            }
            this._InSiteXmlWriter.EndElement();
            this._InSiteXmlWriter.EndElement();
            this._InSiteXmlWriter.EndElement();
            flag = true;
          }
          else if (info1.RequestValue)
          {
            this._InSiteXmlWriter.BeginElement(field.Name);
            this._InSiteXmlWriter.EndElement();
            flag = true;
          }
          if (field.Type != typeof (Info))
          {
            this._InSiteXmlWriter.ReserveElement(field.Name);
            if (this.FillRequestData(field))
            {
              this._InSiteXmlWriter.EndElement();
              flag = true;
            }
            else
              this._InSiteXmlWriter.RollBackElement();
          }
        }
      }
      return flag;
    }

    private void FillInputData(UnknownObjectReader cdo)
    {
      if (cdo["Self"] != null)
        this.FillInputData(cdo["Self"]);
      foreach (UnknownObjectReader field in cdo.Fields)
      {
        if (field.Name != "Self" && field.Name != "ListItemAction" && (field.Name != "FieldAction" && field.Name != "ListItemIndex") && (field.Name != "CDOTypeName" && field.Name != "Key" && field.Name != "IgnoreTypeDifference"))
        {
          string name = this.NormalizeXmlFieldName(cdo.Value, field.Name);
          if (!field.IsArray)
          {
            string str = string.Empty;
            if (field.Type != cdo.Type.GetField(field.Name).FieldType && !typeof (BaseObjectRef).IsAssignableFrom(field.Type) && (field["IgnoreTypeDifference"] == null || !(bool) field["IgnoreTypeDifference"].Value))
              str = field.Type.Name;
            if (field["CDOTypeName"] != null)
              str = field["CDOTypeName"].Value.ToString();
            if (!field.IsSimpleType)
            {
              if (field["FieldAction"] != null)
              {
                if (string.IsNullOrEmpty(str))
                  this._InSiteXmlWriter.BeginElement(name, new string[1]
                  {
                    "__action"
                  }, new object[1]
                  {
                    (object) field["FieldAction"].Value.ToString().ToLower()
                  });
                else
                  this._InSiteXmlWriter.BeginElement(name, new string[2]
                  {
                    "__action",
                    "__CDOTypeName"
                  }, new object[2]
                  {
                    (object) field["FieldAction"].Value.ToString().ToLower(),
                    (object) str
                  });
              }
              else if (string.IsNullOrEmpty(str))
                this._InSiteXmlWriter.BeginElement(name);
              else
                this._InSiteXmlWriter.BeginElement(name, new string[1]
                {
                  "__CDOTypeName"
                }, new object[1]{ (object) str });
              this.FillInputData(field);
              this._InSiteXmlWriter.EndElement();
            }
            else
            {
              if (field["FieldAction"] != null)
                this._InSiteXmlWriter.BeginElement(name, field, new string[1]
                {
                  "__action"
                }, new object[1]
                {
                  (object) field["FieldAction"].Value.ToString().ToLower()
                });
              else
                this._InSiteXmlWriter.BeginElement(name, field);
              this._InSiteXmlWriter.EndElement();
            }
          }
          else
          {
            this._InSiteXmlWriter.BeginElement(name);
            foreach (UnknownObjectReader arrayItem in field.ArrayItems)
            {
              UnknownObjectReader unknownObjectReader = (UnknownObjectReader) null;
              if (arrayItem.Value is IPrimitive)
                unknownObjectReader = new UnknownObjectReader((object) (arrayItem.Value as IPrimitive).ToString());
              string str = string.Empty;
              if (arrayItem.Type != field.Type.GetElementType() && (arrayItem["IgnoreTypeDifference"] == null || !(bool) arrayItem["IgnoreTypeDifference"].Value))
                str = arrayItem.Type.Name;
              if (arrayItem["CDOTypeName"] != null)
                str = arrayItem["CDOTypeName"].Value.ToString();
              if (arrayItem["ListItemAction"] != null)
              {
                if (string.IsNullOrEmpty(str))
                  this._InSiteXmlWriter.BeginElement("__listItem", unknownObjectReader, new string[1]
                  {
                    "__listItemAction"
                  }, new object[1]
                  {
                    (object) arrayItem["ListItemAction"].Value.ToString().ToLower()
                  });
                else
                  this._InSiteXmlWriter.BeginElement("__listItem", unknownObjectReader, new string[2]
                  {
                    "__listItemAction",
                    "__CDOTypeName"
                  }, new object[2]
                  {
                    (object) arrayItem["ListItemAction"].Value.ToString().ToLower(),
                    (object) str
                  });
              }
              else if (string.IsNullOrEmpty(str))
                this._InSiteXmlWriter.BeginElement("__listItem", unknownObjectReader);
              else
                this._InSiteXmlWriter.BeginElement("__listItem", unknownObjectReader, new string[1]
                {
                  "__CDOTypeName"
                }, new object[1]{ (object) str });
              if (arrayItem["ListItemIndex"] != null)
              {
                this._InSiteXmlWriter.BeginElement("__index", arrayItem["ListItemIndex"]);
                this._InSiteXmlWriter.EndElement();
              }
              if (arrayItem["Key"] != null)
              {
                this._InSiteXmlWriter.BeginElement("__key");
                this.FillInputData(arrayItem["Key"]);
                this._InSiteXmlWriter.EndElement();
              }
              if (unknownObjectReader == null)
                this.FillInputData(arrayItem);
              this._InSiteXmlWriter.EndElement();
            }
            this._InSiteXmlWriter.EndElement();
          }
        }
      }
    }

    private void FillResponseData(UnknownObjectWriter result, ResultStatus resultStatus)
    {
      resultStatus.IsSuccess = true;
      InSiteXmlReader inSiteXmlReader1 = this._InSiteXmlReader["__InSite"];
      InSiteXmlReader reader = inSiteXmlReader1["__responseData"];
      InSiteXmlReader inSiteXmlReader2 = inSiteXmlReader1["__debugResponse"];
      if (reader == null)
      {
        reader = inSiteXmlReader1["__service"]["__responseData"];
        inSiteXmlReader2 = inSiteXmlReader1["__service"]["__debugResponse"];
      }
      InSiteXmlReader exceptionData = reader["__exceptionData"];
      if (exceptionData != null)
      {
        this.FillExceptionData(resultStatus, exceptionData);
      }
      else
      {
        resultStatus.Message = reader["CompletionMsg"].Value;
        if (reader["ACEMessage"] != null)
        {
          resultStatus.ACEMessage = reader["ACEMessage"].Value;
          if (reader["ACEStatus"] != null)
            resultStatus.ACEStatus = reader["ACEStatus"].Value;
        }
        this.FillCdoData(result.CreateField("Value"), reader);
        this.FillEnvironmentData(result.CreateField("Environment"), reader);
      }
      if (inSiteXmlReader2 == null)
        return;
      ServerTraceItem root = new ServerTraceItem()
      {
        Name = "Root"
      };
      this.FillDebugData(inSiteXmlReader2.Fields[0], root);
      if (resultStatus.DebugResponse == null)
        resultStatus.DebugResponse = new DebugResponse();
      resultStatus.DebugResponse.Trace = root;
      resultStatus.DebugResponse.Fault = !resultStatus.IsSuccess;
    }

    private void FillDebugData(InSiteXmlReader debugData, ServerTraceItem root)
    {
      root.Name = debugData.Name;
      root.Attributes = debugData.GetAttributes().OfType<XmlAttribute>().Select<XmlAttribute, TraceItemAttribute>((Func<XmlAttribute, TraceItemAttribute>) (a => new TraceItemAttribute()
      {
        Name = a.Name,
        Value = a.Value
      })).ToArray<TraceItemAttribute>();
      List<ServerTraceItem> serverTraceItemList = new List<ServerTraceItem>();
      List<TraceItemParameter> traceItemParameterList = new List<TraceItemParameter>();
      if (debugData.HasFields)
      {
        foreach (InSiteXmlReader field in debugData.Fields)
        {
          if (field.Name == "__parameter")
          {
            TraceItemParameter traceItemParameter = new TraceItemParameter();
            traceItemParameter.Name = field.GetAttribute("__name");
            if (field["__expression"] != null)
              traceItemParameter.Expression = field["__expression"].Value;
            if (field["__resolvedValue"] != null)
              traceItemParameter.Value = field["__resolvedValue"].Value;
            traceItemParameterList.Add(traceItemParameter);
          }
          else if (field.Name == "__startTime")
            root.Started = DateTime.Parse(field.Value);
          else if (field.Name == "__endTime")
            root.Ended = DateTime.Parse(field.Value);
          else if (field.Name == "__startMemoryUsage")
            root.StartedMemoryUsage = int.Parse(field.Value);
          else if (field.Name == "__endMemoryUsage")
          {
            root.EndedMemoryUsage = int.Parse(field.Value);
          }
          else
          {
            ServerTraceItem root1 = new ServerTraceItem();
            serverTraceItemList.Add(root1);
            this.FillDebugData(field, root1);
          }
        }
      }
      else
        root.Value = debugData.Value;
      root.Children = serverTraceItemList.ToArray();
      root.Parameters = traceItemParameterList.ToArray();
    }

    private UnknownObjectWriter WriteReference(
      UnknownObjectWriter writer,
      UnknownObjectWriter cdo,
      string fieldName,
      InSiteXmlReader readerItem)
    {
      BaseObjectRef reference = this.GetReference(readerItem);
      if (reference != null)
      {
        writer = new UnknownObjectWriter((object) reference);
        cdo.SetField(fieldName, (object) reference);
      }
      return writer;
    }

    private BaseObjectRef GetReference(InSiteXmlReader readerItem)
    {
      BaseObjectRef baseObjectRef = new BaseObjectRef();
      if (readerItem.GetAttribute("__nodeType").Equals("SubentityObjRef"))
        baseObjectRef = (BaseObjectRef) new SubentityRef();
      if (readerItem["__rev"] != null || readerItem["__useROR"] != null)
      {
        RevisionedObjectRef revisionedObjectRef = new RevisionedObjectRef();
        revisionedObjectRef.Name = readerItem["__name"].Value;
        if (readerItem["__rev"] != null)
          revisionedObjectRef.Revision = readerItem["__rev"].Value;
        revisionedObjectRef.RevisionOfRecord = new bool?(!string.IsNullOrEmpty(readerItem["__useROR"].Value) && bool.Parse(readerItem["__useROR"].Value));
        baseObjectRef = (BaseObjectRef) revisionedObjectRef;
      }
      else if (readerItem["__level"] != null)
      {
        ContainerRef containerRef = new ContainerRef()
        {
          Name = readerItem["__name"].Value,
          Level = new NamedObjectRef()
        };
        containerRef.Level.Name = readerItem["__level"].Value;
        baseObjectRef = (BaseObjectRef) containerRef;
      }
      else if (readerItem.GetAttribute("__nodeType").Equals("NamedSubentityObjRef") || readerItem["__parent"] != null)
      {
        SubentityRef subentityRef = new SubentityRef();
        if (readerItem["__name"] != null)
          subentityRef = (SubentityRef) new NamedSubentityRef()
          {
            Name = readerItem["__name"].Value
          };
        if (readerItem["__parent"] != null)
          subentityRef.Parent = this.GetReference(readerItem["__parent"]);
        baseObjectRef = (BaseObjectRef) subentityRef;
      }
      else if (readerItem["__name"] != null)
        baseObjectRef = (BaseObjectRef) new NamedObjectRef()
        {
          Name = readerItem["__name"].Value
        };
      if (readerItem["__Id"] != null)
        baseObjectRef.ID = readerItem["__Id"].Value;
      else
        baseObjectRef = (BaseObjectRef) null;
      if (baseObjectRef != null)
        baseObjectRef.CDOTypeName = readerItem.GetAttribute("__CDOTypeName");
      return baseObjectRef;
    }

    private void FillCdoData(UnknownObjectWriter cdo, InSiteXmlReader reader)
    {
      foreach (InSiteXmlReader field1 in reader.Fields)
      {
        string name = field1.Name;
        if (field1.HasFields)
        {
          if (field1.IsList)
          {
            InSiteXmlReader[] list = field1.GetList();
            List<UnknownObjectWriter> array = cdo.CreateArray(field1.Name, list.Length);
            int index = 0;
            foreach (InSiteXmlReader inSiteXmlReader in list)
            {
              if (!(array[index].Value is BaseObjectRef) && !(array[index].Value is IPrimitive))
              {
                string attribute = inSiteXmlReader.GetAttribute("__CDOTypeName");
                if (!string.IsNullOrEmpty(attribute) && attribute != array[index].Type.Name)
                  array[index] = cdo.SetArrayItem(index, field1.Name, attribute);
              }
              if (!(array[index].Value is BaseObjectRef))
              {
                UnknownObjectWriter field2 = array[index].CreateField("Self");
                if (field2 != null)
                  this.WriteReference(field2, array[index], "Self", inSiteXmlReader);
                else
                  array[index].SetField("Value", (object) inSiteXmlReader.Value);
              }
              else
              {
                BaseObjectRef reference = this.GetReference(inSiteXmlReader);
                array[index] = cdo.SetArrayItem(index, field1.Name, (object) reference);
              }
              array[index].SetField("ListItemIndex", (object) index);
              this.FillCdoData(array[index++], inSiteXmlReader);
            }
          }
          else
          {
            UnknownObjectWriter unknownObjectWriter = cdo.CreateField(name);
            if (unknownObjectWriter != null)
            {
              if (!(unknownObjectWriter.Value is BaseObjectRef) && !(unknownObjectWriter.Value is IPrimitive))
              {
                string attribute = field1.GetAttribute("__CDOTypeName");
                if (!string.IsNullOrEmpty(attribute) && attribute != unknownObjectWriter.Type.Name)
                  unknownObjectWriter = cdo.CreateField(name, attribute);
              }
              if (unknownObjectWriter.Value is BaseObjectRef)
                unknownObjectWriter = this.WriteReference(unknownObjectWriter, cdo, name, field1);
              else
                this.WriteReference(unknownObjectWriter.CreateField("Self"), unknownObjectWriter, "Self", field1);
              if (unknownObjectWriter.Value is BaseObjectRef)
                unknownObjectWriter.SetField("CDOTypeName", (object) field1.GetAttribute("__CDOTypeName"));
              this.FillCdoData(unknownObjectWriter, field1);
            }
          }
        }
        else if (name != "CompletionMsg")
          cdo[name] = field1.Value;
      }
    }

    private bool FillEnvironmentData(UnknownObjectWriter environment, InSiteXmlReader reader)
    {
      bool flag1 = false;
      foreach (InSiteXmlReader field1 in reader.Fields)
      {
        string name = this.NormalizeObjectFieldName(environment.Value, field1.Name);
        if (field1.IsList)
        {
          UnknownObjectWriter field2 = environment.CreateField(name);
          if (field2 != null)
          {
            InSiteXmlReader reader1 = field1.GetList()[0];
            if (field2.Type != typeof (Environment))
            {
              string attribute = reader1.GetAttribute("__CDOTypeName");
              if (string.IsNullOrEmpty(attribute))
                attribute = reader1.GetAttribute("__specificType");
              if (!string.IsNullOrEmpty(attribute) && attribute + "_Environment" != field2.Type.Name)
                field2 = environment.CreateField(name, attribute + "_Environment");
            }
            bool flag2 = this.FillEnvironmentData(field2, reader1);
            flag1 |= flag2;
            if (!flag2)
              environment.SetField(name, (object) null);
          }
        }
        else if (field1.Name != "__selectionValuesEx")
        {
          UnknownObjectWriter field2 = environment.CreateField(name);
          if (field2 != null)
          {
            if (field2.Type != typeof (Environment))
            {
              string attribute = field1.GetAttribute("__CDOTypeName");
              if (!string.IsNullOrEmpty(attribute) && attribute + "_Environment" != field2.Type.Name)
                field2 = environment.CreateField(name, attribute + "_Environment");
            }
            bool flag2 = this.FillEnvironmentData(field2, field1);
            flag1 |= flag2;
            if (!flag2)
              environment.SetField(name, (object) null);
          }
        }
        else
        {
          RecordSet recordSet = new RecordSet();
          if (!this.FillRecordSet(field1, recordSet))
            environment.SetField("SelectionValues", (object) recordSet);
          flag1 = true;
        }
      }
      return flag1;
    }

    private string NormalizeObjectFieldName(object value, string name)
    {
      string str = name;
      if (value is DCObject)
      {
        if (name == "__Id")
          str = "ID";
        if (name == "__parent")
          str = "Parent";
      }
      if (value is BaseObjectRef && name == "__name")
        str = "Name";
      if (value is RevisionedObjectRef)
      {
        if (name == "__useROR")
          str = "RevisionOfRecord";
        if (name == "__rev")
          str = "Revision";
      }
      if (value is ContainerRef && name == "__level")
        str = "Level";
      return str;
    }

    private string NormalizeXmlFieldName(object value, string name)
    {
      string str = name;
      if (value is DCObject)
      {
        if (name == "ID")
          str = "__Id";
        if (name == "Parent")
          str = "__parent";
      }
      if (value is BaseObjectRef && name == "Name")
        str = "__name";
      if (value is RevisionedObjectRef)
      {
        if (name == "RevisionOfRecord")
          str = "__useROR";
        if (name == "Revision")
          str = "__rev";
      }
      if (value is ContainerRef && name == "Level")
        str = "__level";
      if (name == "Key")
        str = "__key";
      return str;
    }
  }
}
