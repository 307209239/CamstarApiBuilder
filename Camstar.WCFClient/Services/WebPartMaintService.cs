// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WebPartMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WebPartMaintService : UIProviderComponentMaintBase
  {
    public WebPartMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWebPartMaintService), userProfile);
    }

    public ResultStatus Delete(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).Delete(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus Delete(WebPartMaint webPartMaint)
    {
      return this.Delete(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus Delete(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.Delete(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).Freeze(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus Freeze(WebPartMaint webPartMaint)
    {
      return this.Freeze(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus Freeze(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.Freeze(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).GetWIPMsgs(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(WebPartMaint webPartMaint)
    {
      return this.GetWIPMsgs(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.GetWIPMsgs(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).Load(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus Load(WebPartMaint webPartMaint)
    {
      return this.Load(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus Load(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.Load(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      WebPartMaint webPartMaint,
      WebPartMaint_LoadESigDetails_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).LoadESigDetails(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.LoadESigDetails, (WebPartMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((WebPartMaint) null, (WebPartMaint_LoadESigDetails_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus LoadESigDetails(WebPartMaint webPartMaint)
    {
      return this.LoadESigDetails(webPartMaint, (WebPartMaint_LoadESigDetails_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.LoadESigDetails(webPartMaint, (WebPartMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).New(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus New(WebPartMaint webPartMaint)
    {
      return this.New(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus New(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.New(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).NewCopy(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus NewCopy(WebPartMaint webPartMaint)
    {
      return this.NewCopy(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus NewCopy(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.NewCopy(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).SaveAs(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus SaveAs(WebPartMaint webPartMaint)
    {
      return this.SaveAs(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus SaveAs(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.SaveAs(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      WebPartMaint webPartMaint,
      WebPartMaint_Parameters parameters,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) webPartMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).UnFreeze(this._UserProfile, webPartMaint, parameters, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(webPartMaint, WebPartMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) webPartMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((WebPartMaint) null, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus UnFreeze(WebPartMaint webPartMaint)
    {
      return this.UnFreeze(webPartMaint, (WebPartMaint_Parameters) null, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus UnFreeze(
      WebPartMaint webPartMaint,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.UnFreeze(webPartMaint, (WebPartMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.Delete((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((WebPartMaint) webPartMaint, (WebPartMaint_LoadESigDetails_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.New((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.Load((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject webPartMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WebPartMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WebPartMaint) webPartMaint, (WebPartMaint_Parameters) parameters, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      try
      {
        WebPartMaintMethod[] methods = new WebPartMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWebPartMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WebPartMaint cdo,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      try
      {
        return ((IWebPartMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        WebPartMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((WebPartMaint) cdo, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.GetEnvironment((WebPartMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WebPartMaint cdo,
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      result = (WebPartMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWebPartMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WebPartMaintMethod(cdo, WebPartMaintMethods.ExecuteTransaction, (WebPartMaint_Parameters) null));
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
        WebPartMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WebPartMaint) cdo, (WebPartMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WebPartMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (WebPartMaint_Request) null, out WebPartMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WebPartMaint_Request request,
      out WebPartMaint_Result result)
    {
      return this.ExecuteTransaction((WebPartMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WebPartMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WebPartMaintMethod(cdo, WebPartMaintMethods.AddDataTransaction, (WebPartMaint_Parameters) null));
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
        return this.AddDataTransaction((WebPartMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
