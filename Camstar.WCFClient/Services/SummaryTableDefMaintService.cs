// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SummaryTableDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SummaryTableDefMaintService : NamedDataObjectMaintBase
  {
    public SummaryTableDefMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISummaryTableDefMaintService), userProfile);
    }

    public ResultStatus Delete(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).Delete(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus Delete(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.Delete(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus Delete(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.Delete(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).Freeze(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus Freeze(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.Freeze(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus Freeze(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.Freeze(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).GetWIPMsgs(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.GetWIPMsgs(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.GetWIPMsgs(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).Load(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus Load(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.Load(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus Load(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.Load(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_LoadESigDetails_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).LoadESigDetails(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.LoadESigDetails, (SummaryTableDefMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SummaryTableDefMaint) null, (SummaryTableDefMaint_LoadESigDetails_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.LoadESigDetails(summaryTableDefMaint, (SummaryTableDefMaint_LoadESigDetails_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.LoadESigDetails(summaryTableDefMaint, (SummaryTableDefMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).New(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus New(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.New(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus New(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.New(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).NewCopy(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus NewCopy(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.NewCopy(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus NewCopy(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.NewCopy(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).SaveAs(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus SaveAs(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.SaveAs(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus SaveAs(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.SaveAs(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Parameters parameters,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).UnFreeze(this._UserProfile, summaryTableDefMaint, parameters, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(summaryTableDefMaint, SummaryTableDefMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) summaryTableDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SummaryTableDefMaint) null, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus UnFreeze(SummaryTableDefMaint summaryTableDefMaint)
    {
      return this.UnFreeze(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SummaryTableDefMaint summaryTableDefMaint,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.UnFreeze(summaryTableDefMaint, (SummaryTableDefMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_LoadESigDetails_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.New((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.Load((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject summaryTableDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SummaryTableDefMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SummaryTableDefMaint) summaryTableDefMaint, (SummaryTableDefMaint_Parameters) parameters, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      try
      {
        SummaryTableDefMaintMethod[] methods = new SummaryTableDefMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISummaryTableDefMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SummaryTableDefMaint cdo,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      try
      {
        return ((ISummaryTableDefMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SummaryTableDefMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SummaryTableDefMaint) cdo, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.GetEnvironment((SummaryTableDefMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SummaryTableDefMaint cdo,
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      result = (SummaryTableDefMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISummaryTableDefMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SummaryTableDefMaintMethod(cdo, SummaryTableDefMaintMethods.ExecuteTransaction, (SummaryTableDefMaint_Parameters) null));
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
        SummaryTableDefMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SummaryTableDefMaint) cdo, (SummaryTableDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SummaryTableDefMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SummaryTableDefMaint_Request) null, out SummaryTableDefMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SummaryTableDefMaint_Request request,
      out SummaryTableDefMaint_Result result)
    {
      return this.ExecuteTransaction((SummaryTableDefMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SummaryTableDefMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SummaryTableDefMaintMethod(cdo, SummaryTableDefMaintMethods.AddDataTransaction, (SummaryTableDefMaint_Parameters) null));
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
        return this.AddDataTransaction((SummaryTableDefMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
