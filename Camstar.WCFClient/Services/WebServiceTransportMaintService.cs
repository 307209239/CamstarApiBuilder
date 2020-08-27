// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WebServiceTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WebServiceTransportMaintService : DataTransportMaintBase
  {
    public WebServiceTransportMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWebServiceTransportMaintService), userProfile);
    }

    public ResultStatus Delete(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).Delete(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus Delete(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.Delete(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus Delete(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.Delete(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).Freeze(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus Freeze(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.Freeze(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus Freeze(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.Freeze(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).GetWIPMsgs(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.GetWIPMsgs(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.GetWIPMsgs(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).Load(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus Load(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.Load(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus Load(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.Load(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_LoadESigDetails_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).LoadESigDetails(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.LoadESigDetails, (WebServiceTransportMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((WebServiceTransportMaint) null, (WebServiceTransportMaint_LoadESigDetails_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.LoadESigDetails(webServiceTransportMaint, (WebServiceTransportMaint_LoadESigDetails_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.LoadESigDetails(webServiceTransportMaint, (WebServiceTransportMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).New(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus New(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.New(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus New(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.New(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).NewCopy(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus NewCopy(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.NewCopy(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus NewCopy(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.NewCopy(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).SaveAs(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus SaveAs(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.SaveAs(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus SaveAs(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.SaveAs(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Parameters parameters,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).UnFreeze(this._UserProfile, webServiceTransportMaint, parameters, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(webServiceTransportMaint, WebServiceTransportMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) webServiceTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((WebServiceTransportMaint) null, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(WebServiceTransportMaint webServiceTransportMaint)
    {
      return this.UnFreeze(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(
      WebServiceTransportMaint webServiceTransportMaint,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.UnFreeze(webServiceTransportMaint, (WebServiceTransportMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.Delete((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_LoadESigDetails_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.New((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.Load((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject webServiceTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WebServiceTransportMaint) webServiceTransportMaint, (WebServiceTransportMaint_Parameters) parameters, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      try
      {
        WebServiceTransportMaintMethod[] methods = new WebServiceTransportMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWebServiceTransportMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WebServiceTransportMaint cdo,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      try
      {
        return ((IWebServiceTransportMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((WebServiceTransportMaint) cdo, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.GetEnvironment((WebServiceTransportMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WebServiceTransportMaint cdo,
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      result = (WebServiceTransportMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebServiceTransportMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WebServiceTransportMaintMethod(cdo, WebServiceTransportMaintMethods.ExecuteTransaction, (WebServiceTransportMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebServiceTransportMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WebServiceTransportMaint) cdo, (WebServiceTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WebServiceTransportMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (WebServiceTransportMaint_Request) null, out WebServiceTransportMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WebServiceTransportMaint_Request request,
      out WebServiceTransportMaint_Result result)
    {
      return this.ExecuteTransaction((WebServiceTransportMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WebServiceTransportMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WebServiceTransportMaintMethod(cdo, WebServiceTransportMaintMethods.AddDataTransaction, (WebServiceTransportMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((WebServiceTransportMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
