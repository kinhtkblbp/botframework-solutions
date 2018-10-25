/**
* <auto-generated>
* Code generated by LUISGen .\deploymentScripts\msbotClone\120.luis -ts LuisGeneral -o .\src\dialogs\shared\resources
* Tool github: https://github.com/microsoft/botbuilder-tools
* Changes may cause incorrect behavior and will be lost if the code is
* regenerated.
* </auto-generated>
*/
import {DateTimeSpec, InstanceData, IntentData} from "botbuilder-ai";

export interface _Intents {
    Cancel: IntentData;
    ConfirmMore: IntentData;
    ConfirmNo: IntentData;
    ConfirmYes: IntentData;
    Escalate: IntentData;
    Goodbye: IntentData;
    Greeting: IntentData;
    Help: IntentData;
    Next: IntentData;
    None: IntentData;
    Restart: IntentData;
}

export interface _Instance {
    datetime?: InstanceData[];
    number?: InstanceData[];
}

export interface _Entities {

    // Built-in entities
    datetime?: DateTimeSpec[];
    number?: number[];
    $instance: _Instance;
}

export interface LuisGeneral {
    text: string;
    alteredText?: string;
    intents: _Intents;
    entities: _Entities;
    [propName: string]: any;
}
