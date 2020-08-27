// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ScrapReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ScrapReasonMaintService : UserCodeMaintBase
  {
    public ScrapReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IScrapReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).Delete(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus Delete(ScrapReasonMaint scrapReasonMaint)
    {
      return this.Delete(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.Delete(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).Freeze(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus Freeze(ScrapReasonMaint scrapReasonMaint)
    {
      return this.Freeze(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.Freeze(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ScrapReasonMaint scrapReasonMaint)
    {
      return this.GetWIPMsgs(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.GetWIPMsgs(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).Load(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus Load(ScrapReasonMaint scrapReasonMaint)
    {
      return this.Load(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus Load(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.Load(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_LoadESigDetails_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.LoadESigDetails, (ScrapReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ScrapReasonMaint) null, (ScrapReasonMaint_LoadESigDetails_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ScrapReasonMaint scrapReasonMaint)
    {
      return this.LoadESigDetails(scrapReasonMaint, (ScrapReasonMaint_LoadESigDetails_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.LoadESigDetails(scrapReasonMaint, (ScrapReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).New(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus New(ScrapReasonMaint scrapReasonMaint)
    {
      return this.New(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus New(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.New(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).NewCopy(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ScrapReasonMaint scrapReasonMaint)
    {
      return this.NewCopy(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.NewCopy(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).SaveAs(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ScrapReasonMaint scrapReasonMaint)
    {
      return this.SaveAs(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.SaveAs(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Parameters parameters,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).UnFreeze(this._UserProfile, scrapReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(scrapReasonMaint, ScrapReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) scrapReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ScrapReasonMaint) null, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ScrapReasonMaint scrapReasonMaint)
    {
      return this.UnFreeze(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScrapReasonMaint scrapReasonMaint,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.UnFreeze(scrapReasonMaint, (ScrapReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_LoadESigDetails_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject scrapReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScrapReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ScrapReasonMaint) scrapReasonMaint, (ScrapReasonMaint_Parameters) parameters, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      try
      {
        ScrapReasonMaintMethod[] methods = new ScrapReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IScrapReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScrapReasonMaint cdo,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      try
      {
        return ((IScrapReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ScrapReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ScrapReasonMaint) cdo, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.GetEnvironment((ScrapReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ScrapReasonMaint cdo,
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      result = (ScrapReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScrapReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ScrapReasonMaintMethod(cdo, ScrapReasonMaintMethods.ExecuteTransaction, (ScrapReasonMaint_Parameters) null));
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
        ScrapReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ScrapReasonMaint) cdo, (ScrapReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ScrapReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ScrapReasonMaint_Request) null, out ScrapReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ScrapReasonMaint_Request request,
      out ScrapReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ScrapReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ScrapReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ScrapReasonMaintMethod(cdo, ScrapReasonMaintMethods.AddDataTransaction, (ScrapReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ScrapReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
