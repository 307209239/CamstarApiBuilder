// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ScaleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ScaleMaintService : ResourceMaintBase
  {
    public ScaleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IScaleMaintService), userProfile);
    }

    public ResultStatus Delete(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).Delete(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus Delete(ScaleMaint scaleMaint)
    {
      return this.Delete(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus Delete(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.Delete(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).Freeze(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus Freeze(ScaleMaint scaleMaint)
    {
      return this.Freeze(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus Freeze(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.Freeze(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ScaleMaint scaleMaint)
    {
      return this.GetWIPMsgs(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.GetWIPMsgs(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).Load(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus Load(ScaleMaint scaleMaint)
    {
      return this.Load(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus Load(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.Load(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ScaleMaint scaleMaint,
      ScaleMaint_LoadESigDetails_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).LoadESigDetails(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.LoadESigDetails, (ScaleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ScaleMaint) null, (ScaleMaint_LoadESigDetails_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ScaleMaint scaleMaint)
    {
      return this.LoadESigDetails(scaleMaint, (ScaleMaint_LoadESigDetails_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.LoadESigDetails(scaleMaint, (ScaleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).New(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus New(ScaleMaint scaleMaint)
    {
      return this.New(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus New(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.New(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).NewCopy(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus NewCopy(ScaleMaint scaleMaint)
    {
      return this.NewCopy(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.NewCopy(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).SaveAs(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus SaveAs(ScaleMaint scaleMaint)
    {
      return this.SaveAs(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.SaveAs(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ScaleMaint scaleMaint,
      ScaleMaint_Parameters parameters,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) scaleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).UnFreeze(this._UserProfile, scaleMaint, parameters, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(scaleMaint, ScaleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) scaleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ScaleMaint) null, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus UnFreeze(ScaleMaint scaleMaint)
    {
      return this.UnFreeze(scaleMaint, (ScaleMaint_Parameters) null, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScaleMaint scaleMaint,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.UnFreeze(scaleMaint, (ScaleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ScaleMaint) scaleMaint, (ScaleMaint_LoadESigDetails_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.New((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.Load((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject scaleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScaleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ScaleMaint) scaleMaint, (ScaleMaint_Parameters) parameters, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      try
      {
        ScaleMaintMethod[] methods = new ScaleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IScaleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleMaint cdo,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      try
      {
        return ((IScaleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ScaleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ScaleMaint) cdo, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.GetEnvironment((ScaleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ScaleMaint cdo,
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      result = (ScaleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScaleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ScaleMaintMethod(cdo, ScaleMaintMethods.ExecuteTransaction, (ScaleMaint_Parameters) null));
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
        ScaleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ScaleMaint) cdo, (ScaleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ScaleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ScaleMaint_Request) null, out ScaleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ScaleMaint_Request request,
      out ScaleMaint_Result result)
    {
      return this.ExecuteTransaction((ScaleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ScaleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ScaleMaintMethod(cdo, ScaleMaintMethods.AddDataTransaction, (ScaleMaint_Parameters) null));
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
        return this.AddDataTransaction((ScaleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
