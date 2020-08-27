// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SellReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SellReasonMaintService : UserCodeMaintBase
  {
    public SellReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISellReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).Delete(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus Delete(SellReasonMaint sellReasonMaint)
    {
      return this.Delete(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus Delete(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.Delete(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).Freeze(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus Freeze(SellReasonMaint sellReasonMaint)
    {
      return this.Freeze(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.Freeze(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SellReasonMaint sellReasonMaint)
    {
      return this.GetWIPMsgs(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.GetWIPMsgs(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).Load(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus Load(SellReasonMaint sellReasonMaint)
    {
      return this.Load(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus Load(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.Load(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_LoadESigDetails_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.LoadESigDetails, (SellReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SellReasonMaint) null, (SellReasonMaint_LoadESigDetails_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SellReasonMaint sellReasonMaint)
    {
      return this.LoadESigDetails(sellReasonMaint, (SellReasonMaint_LoadESigDetails_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.LoadESigDetails(sellReasonMaint, (SellReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).New(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus New(SellReasonMaint sellReasonMaint)
    {
      return this.New(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus New(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.New(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).NewCopy(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus NewCopy(SellReasonMaint sellReasonMaint)
    {
      return this.NewCopy(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.NewCopy(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).SaveAs(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus SaveAs(SellReasonMaint sellReasonMaint)
    {
      return this.SaveAs(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.SaveAs(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).UnFreeze(this._UserProfile, sellReasonMaint, parameters, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(sellReasonMaint, SellReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) sellReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SellReasonMaint) null, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(SellReasonMaint sellReasonMaint)
    {
      return this.UnFreeze(sellReasonMaint, (SellReasonMaint_Parameters) null, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.UnFreeze(sellReasonMaint, (SellReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SellReasonMaint) sellReasonMaint, (SellReasonMaint_LoadESigDetails_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sellReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SellReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SellReasonMaint) sellReasonMaint, (SellReasonMaint_Parameters) parameters, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      try
      {
        SellReasonMaintMethod[] methods = new SellReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISellReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SellReasonMaint cdo,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      try
      {
        return ((ISellReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SellReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SellReasonMaint) cdo, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.GetEnvironment((SellReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SellReasonMaint cdo,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      result = (SellReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISellReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SellReasonMaintMethod(cdo, SellReasonMaintMethods.ExecuteTransaction, (SellReasonMaint_Parameters) null));
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
        SellReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SellReasonMaint) cdo, (SellReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SellReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SellReasonMaint_Request) null, out SellReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result)
    {
      return this.ExecuteTransaction((SellReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SellReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SellReasonMaintMethod(cdo, SellReasonMaintMethods.AddDataTransaction, (SellReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((SellReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
